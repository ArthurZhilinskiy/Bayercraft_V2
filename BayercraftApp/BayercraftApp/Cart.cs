using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace BayercraftApp
{
    public partial class Cart : UserControl
    {
        public string ID { get; set; }
        public string Category { get; set; }
        public string  Name { get; set; }
        public string  Description { get; set; }
        public string  Price { get; set; }
        public Image  Image { get; set; }
        public string  ID_Марки { get; set; }
        public UCChooseMarkAndShowProduct UC { get; set; }

        public Cart()
        {
            InitializeComponent();
        }

        public Cart(string category, string ID, string name, string description, string price, Image image, string id_Марки, UCChooseMarkAndShowProduct uc)
        {
            InitializeComponent();
            this.ID = ID;
            Category = category;
            Name = name;
            Description = description;
            Price = price;
            Image = image;
            ID_Марки = id_Марки;
            UC = uc;

            pictureBox1.Image = Image;
            lPrice.Text = Price;
            rtbDescription.Text = Description;
            UCDeleter deleter = new UCDeleter();
            deleter.pictureBox1.Click += new System.EventHandler(deleterMethod);
            pictureBox1.Controls.Add(deleter);
            deleter.Location = new Point(160, 3);

            UCUpdate updater = new UCUpdate();
            updater.pictureBox1.Click += new System.EventHandler(showUpdateControl);
            pictureBox1.Controls.Add(updater);
            updater.Location = new Point(163, 30);
        }

        void showUpdateControl(object sender, EventArgs e)
        {
            UC.flowLayoutPanel1.Controls.Clear();
            UC.flowLayoutPanel1.Controls.Add(new UCChange( UC, Name, Description, Price, Image, ID_Марки, Category, Name ));
        }

        string connstring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\Bayerncraft.mdb";

        void deleterMethod(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand("DELETE *  FROM ["+Category+"] WHERE ID = ?", connection);
                OleDbParameter parameter = new OleDbParameter("ID", OleDbType.Integer);
                parameter.Value = Convert.ToInt32(ID);
                command.Parameters.Add(parameter);

                command.ExecuteNonQuery();               
                MetroFramework.MetroMessageBox.Show(this, "Запись удалена!", "Удаление записи");
                UC.flowLayoutPanel1.Controls.Clear();
                UC.LoadProducts(UC.lNameCategory.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        string getID_Пользователя()
        {
            string result = "";
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand("SELECT ID_Пользователя FROM Пользователи WHERE Логин = ?", connection);
                OleDbParameter parameter = new OleDbParameter("Логин", OleDbType.VarChar);
                parameter.Value = UC.lNameUser.Text;
                command.Parameters.Add(parameter);

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    return reader["ID_Пользователя"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return result;
        }


        private void btnOK_Click_1(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand("INSERT INTO Корзина(ID_Пользователя, Название, Описание, Цена, Изображение) VALUES(?,?,?,?,?)", connection);
                OleDbParameter parameter = new OleDbParameter("ID_Пользователя", OleDbType.Integer);
                parameter.Value = Convert.ToInt32(getID_Пользователя());
                command.Parameters.Add(parameter);

                OleDbParameter parameter1 = new OleDbParameter("Название", OleDbType.VarChar);
                parameter1.Value = Name;
                command.Parameters.Add(parameter1);

                OleDbParameter parameter2 = new OleDbParameter("Описание", OleDbType.VarChar);
                parameter2.Value = Description;
                command.Parameters.Add(parameter2);

                OleDbParameter parameter3 = new OleDbParameter("Цена", OleDbType.Integer);
                parameter3.Value = Convert.ToInt32(Price);
                command.Parameters.Add(parameter3);

                Image image = pictureBox1.Image;

                MemoryStream memoryStream = new MemoryStream();
                System.Drawing.Imaging.ImageFormat format = pictureBox1.Image.RawFormat;
                image.Save(memoryStream, format);
                OleDbParameter parameter4 = new OleDbParameter("Изображение", OleDbType.Binary);
                parameter4.Value = memoryStream.ToArray();
                command.Parameters.Add(parameter4);

                command.ExecuteNonQuery();

                MetroFramework.MetroMessageBox.Show(this, "Товар добавлен в корзину!", "Корзина");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}

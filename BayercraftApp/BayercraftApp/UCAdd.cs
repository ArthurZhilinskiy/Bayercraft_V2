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
    public partial class UCAdd : UserControl
    {
        public MainForm MainForm { get; set; }
        public UCChooseMarkAndShowProduct UC { get; set; }
        public UCAdd(MainForm mainForm, UCChooseMarkAndShowProduct uc)
        {
            InitializeComponent();
            LoadMarks();
            MainForm = mainForm;
            UC = uc;
        }
        string connstring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\Bayerncraft.mdb";

        void LoadMarks()
        {
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand("SELECT Название FROM [Марки авто]", connection);

                OleDbDataReader reader = command.ExecuteReader();
               
                while (reader.Read())
                {
                    cmbMarks.Items.Add(reader["Название"].ToString());
                }
                reader.Close();
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

        void InsertNewMark(string name)
        {
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand("INSERT INTO [Марки авто](Название) VALUES(?)", connection);
                OleDbParameter parameter = new OleDbParameter("Название", OleDbType.VarChar);
                parameter.Value = name;
                command.Parameters.Add(parameter);

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cmbMarks.Items.Add(reader["Название"].ToString());
                }
                reader.Close();
                MetroFramework.MetroMessageBox.Show(this, "Запись успешно добавлена", "Доавление новой марки");
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


        bool isMarkExists(string name)
        {
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand("SELECT Название FROM [Марки авто] WHERE Название = ?", connection);
                OleDbParameter parameter = new OleDbParameter("Название", OleDbType.VarChar);
                parameter.Value = name;
                command.Parameters.Add(parameter);

                OleDbDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    return true;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return false;
        }

        private void btnAddNewMark_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(tbMark.Text))
            {
                if (!isMarkExists(tbMark.Text))
                {
                    InsertNewMark(tbMark.Text);
                    cmbMarks.Items.Clear();
                    LoadMarks();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Такая марка уже записана! Введите другое название марки.", "Ошибка при добавлении новой марки");
                }
             
            }
            else
            {
                tbMark.WithError = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MainForm.flowLayoutPanel1.Controls.Clear();
            MainForm.metroPanel1.Enabled = true;
            MainForm.flowLayoutPanel1.Controls.Add(UC);
            UC.cmbMarks.Items.Clear();
            UC.LoadMarks();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = GetImage();
        }

        Image GetImage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "All files(*.*) | *.*";
            Image img = Properties.Resources.icons8_unsplash_80;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
               img  = Image.FromFile(openFileDialog.FileName);
            }
            return img;
        }

        string getID_Марки(string mark)
        {
            string ID_Марки = "";

            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand("SELECT ID_Марки FROM [Марки авто] WHERE Название = ?", connection);
                OleDbParameter parameter = new OleDbParameter("Название", OleDbType.VarChar);
                parameter.Value = mark;
                command.Parameters.Add(parameter);

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ID_Марки = reader["ID_Марки"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return ID_Марки;
        }

        void InsertNewProduct(string name, string description, string price, Image image, string mark, string category)
        {
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();
                
                OleDbCommand command = new OleDbCommand("INSERT INTO ["+category+"](Название, Описание, Цена, Изображение, ID_Марки) VALUES(?, ?, ?, ?, ?)", connection);
                OleDbParameter parameter = new OleDbParameter("Название", OleDbType.VarChar);
                parameter.Value = name;
                command.Parameters.Add(parameter);

                OleDbParameter parameter1 = new OleDbParameter("Описание", OleDbType.VarChar);
                parameter1.Value = description;
                command.Parameters.Add(parameter1);

                OleDbParameter parameter2 = new OleDbParameter("Цена", OleDbType.Integer);
                parameter2.Value = Convert.ToInt32(price);
                command.Parameters.Add(parameter2);

                MemoryStream memoryStream = new MemoryStream();
                System.Drawing.Imaging.ImageFormat format = image.RawFormat;
                image.Save(memoryStream, format);
                OleDbParameter parameter3 = new OleDbParameter("Изображение", OleDbType.Binary);
                parameter3.Value = memoryStream.ToArray();
                command.Parameters.Add(parameter3);

                OleDbParameter parameter4 = new OleDbParameter("ID_Марки", OleDbType.Integer);
                parameter4.Value = Convert.ToInt32(getID_Марки(mark));
                command.Parameters.Add(parameter4);

                command.ExecuteNonQuery();

                MetroFramework.MetroMessageBox.Show(this, "Запись успешно добавлена", "Доавление нового товара");
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

       

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            string name;
            string description;
            string price;
            string marka;
            string category;
            Image image;
            if (!String.IsNullOrWhiteSpace(tbName.Text))
            {
                if (!String.IsNullOrWhiteSpace(tbDescription.Text))
                {
                    if (!String.IsNullOrWhiteSpace(tbPrice.Text))
                    {
                        if (!String.IsNullOrWhiteSpace(cmbMarks.Text))
                        {
                            if (!String.IsNullOrWhiteSpace(cmbCategory.Text))
                            {
                                name = tbName.Text;
                                description = tbDescription.Text;
                                price = tbPrice.Text;
                                marka = cmbMarks.Text;
                                category = cmbCategory.Text;
                                image = pictureBox1.Image;
                                InsertNewProduct(name, description, price, image, marka, category);
                            }
                            else
                            {
                                MessageBox.Show("Выберите категорию товара");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Выберите производителя (марку) товара");
                        }
                    }
                    else
                    {
                        tbPrice.WithError = true;
                    }
                }
                else
                {
                    tbDescription.WithError = true;
                }
            }
            else
            {
                tbName.WithError = true;
            }
        }
    }
}

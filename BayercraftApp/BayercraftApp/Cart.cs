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

        private void btnOK_Click_1(object sender, EventArgs e)
        {

        }
    }
}

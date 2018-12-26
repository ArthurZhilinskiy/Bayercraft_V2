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
 
    public partial class UCChange : UserControl
    {
        public UCChooseMarkAndShowProduct UC { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string price { get; set; }
        public string ID_Марки { get; set; }
        public string category { get; set; }
        public Image image { get; set; }
        public string oldName { get; set; }
        public UCChange(UCChooseMarkAndShowProduct uc, string name, string description, string price, Image image, string ID_Марки, string category, string oldName)
        {
            InitializeComponent();
        
            UC = uc;
            this.name = name;
            this.description = description;
            this.price = price;
            this.image = image;
            this.ID_Марки = ID_Марки;
            this.category = category;
            this.oldName = oldName;

            tbName.Text = name;
            tbPrice.Text = price;
            tbDescription.Text = description;
            pictureBox1.Image = image;
            cmbCategory.Text = category;

        }

        string connstring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\Bayerncraft.mdb";

        

        void UpdateProduct(string name, string description, string price, Image image, string mark, string category, string oldName)
        {
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand("UPDATE [" + category + "] SET Название = ?, Описание = ?, Цена = ?, Изображение = ?, ID_Марки = ? WHERE ["+category+"].Название = ?", connection);
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
                parameter4.Value = Convert.ToInt32(ID_Марки);
                command.Parameters.Add(parameter4);

                OleDbParameter parameter5 = new OleDbParameter("["+category+"].Название", OleDbType.VarChar);
                parameter5.Value = oldName;
                command.Parameters.Add(parameter5);

                command.ExecuteNonQuery();

                MetroFramework.MetroMessageBox.Show(this, "Запись успешно обновлена!", "Обновление товара");
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

        private void btnChangeProduct_Click(object sender, EventArgs e)
        {
            
            if (!String.IsNullOrWhiteSpace(tbName.Text))
            {
                if (!String.IsNullOrWhiteSpace(tbDescription.Text))
                {
                    if (!String.IsNullOrWhiteSpace(tbPrice.Text))
                    {
                        if (!String.IsNullOrWhiteSpace(cmbCategory.Text))
                        {
                            name = tbName.Text;
                            description = tbDescription.Text;
                            price = tbPrice.Text;
                            category = cmbCategory.Text;
                            image = pictureBox1.Image;
                            UpdateProduct(name, description, price, image, ID_Марки, category, oldName);
                        }
                        else
                        {
                            MessageBox.Show("Выберите категорию товара");
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            UC.flowLayoutPanel1.Controls.Clear();
            UC.LoadProducts(UC.lNameCategory.Text);
          
        }
    }
}

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
    public partial class UCBacket : UserControl
    {
        public string UserLogin { get; set; }
        public MainForm MainForm { get; set; }
        public UCChooseMarkAndShowProduct UC { get; set; }
    
        public UCBacket(string UserLogin,MainForm mainForm, UCChooseMarkAndShowProduct uc)
        {
            InitializeComponent();
            this.MainForm = mainForm;
            UC = uc;

            this.UserLogin = UserLogin;
            lUserName.Text = UserLogin;
            

            LoadBacket(UserLogin);
        }
        string connstring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\Bayerncraft.mdb";

        void LoadBacket(string UserLogin)
        {
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand("SELECT Название, Описание, Цена, Изображение FROM Корзина WHERE [Корзина].ID_Пользователя = (SELECT ID_Пользователя FROM Пользователи WHERE Логин = ?)", connection);
                OleDbParameter parameter = new OleDbParameter("Логин", OleDbType.VarChar);
                parameter.Value = UserLogin;
                command.Parameters.Add(parameter);

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Image image;

                    if (!reader.IsDBNull(reader.GetOrdinal("Изображение")))
                    {
                        MemoryStream memoryStream = new MemoryStream();
                        memoryStream.Write((byte[])reader["Изображение"], 0, ((byte[])reader["Изображение"]).Length);
                        image = Image.FromStream(memoryStream);
                    }
                    else
                    {
                        image = Properties.Resources.icons8_unsplash_80;
                    }
                    flowLayoutPanel1.Controls.Add(new UCBacketCart(reader["Название"].ToString(), reader["Описание"].ToString(), reader["Цена"].ToString(), image));
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            MainForm.flowLayoutPanel1.Controls.Clear();
            MainForm.metroPanel1.Enabled = true;
            MainForm.flowLayoutPanel1.Controls.Add(UC);
            UC.cmbMarks.Items.Clear();
            UC.LoadMarks();
        }
    }
}

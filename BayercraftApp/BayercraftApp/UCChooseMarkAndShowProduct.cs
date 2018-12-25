﻿using System;
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
    public partial class UCChooseMarkAndShowProduct : UserControl
    {
        public UCChooseMarkAndShowProduct()
        {
            InitializeComponent();
            LoadMarks();
            LoadProducts(lNameCategory.Text);
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

        void LoadProducts(string nameCutegory)
        {
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand("SELECT * FROM ["+nameCutegory+"]", connection);

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                  
                    Image image;
                    
                    if (!reader.IsDBNull(reader.GetOrdinal("Изображение")))
                    {
                        MemoryStream memoryStream = new MemoryStream();
                        memoryStream.Write((byte[])reader["Изображение"], 0, ((byte[])reader["Изображение"]).Length);
                        image = Image.FromStream(memoryStream);
                    }else
                    { 
                        image = Properties.Resources.icons8_unsplash_80;
                    }
                    flowLayoutPanel1.Controls.Add(new Cart(reader["Название"].ToString(),
                                                           reader["Описание"].ToString(),
                                                           reader["Цена"].ToString(),
                                                           image,
                                                           reader["ID_Марки"].ToString())
                                                           );
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
        void LoadProducts(string nameCutegory, string marka)
        {
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand("SELECT * FROM [" + nameCutegory + "] WHERE ID_Марки = (SELECT ID_Марки FROM [Марки авто] WHERE Название = ?)", connection);
                OleDbParameter parameter = new OleDbParameter("Название", OleDbType.VarChar);
                parameter.Value = marka;
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
                    flowLayoutPanel1.Controls.Add(new Cart(reader["Название"].ToString(),
                                                           reader["Описание"].ToString(),
                                                           reader["Цена"].ToString(),
                                                           image,
                                                           reader["ID_Марки"].ToString())
                                                           );
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

        //ПОИСК ПО НАЗВАНИЮ
        //void LoadProducts(string nameCutegory, string marka, string name)
        //{
        //    OleDbConnection connection = new OleDbConnection(connstring);
        //    try
        //    {
        //        connection.Open();

        //        OleDbCommand command = new OleDbCommand("SELECT * FROM [" + nameCutegory + "] WHERE ID_Марки = (SELECT ID_Марки FROM [Марки авто] WHERE Название = ?) AND ["+nameCutegory+ "].Название LIKE  \"?*\"", connection);
        //        OleDbParameter parameter = new OleDbParameter("Название", OleDbType.VarChar);
        //        parameter.Value = marka;
        //        command.Parameters.Add(parameter);

        //        OleDbParameter parameter1 = new OleDbParameter("["+nameCutegory+"].Название", OleDbType.VarChar);
        //        parameter1.Value = name;
        //        command.Parameters.Add(parameter1);

        //        OleDbDataReader reader = command.ExecuteReader();

        //        while (reader.Read())
        //        {

        //            Image image;

        //            if (!reader.IsDBNull(reader.GetOrdinal("Изображение")))
        //            {
        //                MemoryStream memoryStream = new MemoryStream();
        //                memoryStream.Write((byte[])reader["Изображение"], 0, ((byte[])reader["Изображение"]).Length);
        //                image = Image.FromStream(memoryStream);
        //            }
        //            else
        //            {
        //                image = Properties.Resources.icons8_unsplash_80;
        //            }
        //            flowLayoutPanel1.Controls.Add(new Cart(reader["Название"].ToString(),
        //                                                   reader["Описание"].ToString(),
        //                                                   reader["Цена"].ToString(),
        //                                                   image,
        //                                                   reader["ID_Марки"].ToString())
        //                                                   );
        //        }
        //        reader.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //}
        //void LoadProductsWithoutMarka(string nameCutegory, string name)
        //{
        //    OleDbConnection connection = new OleDbConnection(connstring);
        //    try
        //    {
        //        connection.Open();

        //        OleDbCommand command = new OleDbCommand("SELECT * FROM [" + nameCutegory + "] WHERE Название LIKE \"?*\"", connection);
        //        OleDbParameter parameter = new OleDbParameter("Название", OleDbType.VarChar);
        //        parameter.Value = name;
        //        command.Parameters.Add(parameter);

        //        OleDbDataReader reader = command.ExecuteReader();

        //        while (reader.Read())
        //        {

        //            Image image;

        //            if (!reader.IsDBNull(reader.GetOrdinal("Изображение")))
        //            {
        //                MemoryStream memoryStream = new MemoryStream();
        //                memoryStream.Write((byte[])reader["Изображение"], 0, ((byte[])reader["Изображение"]).Length);
        //                image = Image.FromStream(memoryStream);
        //            }
        //            else
        //            {
        //                image = Properties.Resources.icons8_unsplash_80;
        //            }
        //            flowLayoutPanel1.Controls.Add(new Cart(reader["Название"].ToString(),
        //                                                   reader["Описание"].ToString(),
        //                                                   reader["Цена"].ToString(),
        //                                                   image,
        //                                                   reader["ID_Марки"].ToString())
        //                                                   );
        //        }
        //        reader.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //}

        private void lNameCategory_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            cmbMarks.SelectedIndex = -1;
            LoadProducts(lNameCategory.Text);
        }

        private void cmbMarks_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            MetroFramework.Controls.MetroComboBox cmb = sender as MetroFramework.Controls.MetroComboBox;
            LoadProducts(lNameCategory.Text, cmb.Text);
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            //ВЫзов соотвествующих методов поиска

            //flowLayoutPanel1.Controls.Clear();
            //if (cmbMarks.SelectedIndex != -1)
            //{
            //    MetroFramework.Controls.MetroTextBox tb = sender as MetroFramework.Controls.MetroTextBox;
            //    LoadProducts(lNameCategory.Text, cmbMarks.Text, tb.Text);
            //}
            //else
            //{
            //    MetroFramework.Controls.MetroTextBox tb = sender as MetroFramework.Controls.MetroTextBox;
            //    LoadProductsWithoutMarka(lNameCategory.Text, tb.Text);
            //}
        }
    }
}
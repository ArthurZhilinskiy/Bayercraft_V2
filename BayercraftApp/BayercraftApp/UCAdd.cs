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
    }
}

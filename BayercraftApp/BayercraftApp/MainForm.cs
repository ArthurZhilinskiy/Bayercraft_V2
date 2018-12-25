using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BayercraftApp
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        UCChooseMarkAndShowProduct uc;
        public MainForm()
        {
            InitializeComponent();
            uc = new UCChooseMarkAndShowProduct();
            flowLayoutPanel1.Controls.Add(uc);
        }

        private void Hover(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.Font = new Font(label.Font, FontStyle.Underline);
            label.ForeColor = Color.Red;
        }

        private void Leave(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.Font = new Font(label.Font, FontStyle.Regular);
            label.ForeColor = Color.SteelBlue;
        }

        private void Click_Category(object sender, EventArgs e)
        {
            Label label = sender as Label;
            uc.lNameCategory.Text = label.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(new UCAdd(this, uc));
            metroPanel1.Enabled = false;
        }
    }
}

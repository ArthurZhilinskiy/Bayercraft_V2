using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BayercraftApp
{
    public partial class Cart : UserControl
    {
        public string  Name { get; set; }
        public string  Description { get; set; }
        public string  Price { get; set; }
        public Image  Image { get; set; }
        public string  ID_Марки { get; set; }


        public Cart()
        {
            InitializeComponent();
        }

        public Cart(string name, string description, string price, Image image, string id_Марки)
        {
            InitializeComponent();

            Name = name;
            Description = description;
            Price = price;
            Image = image;
            ID_Марки = id_Марки;

            pictureBox1.Image = Image;
            lPrice.Text = Price;
            rtbDescription.Text = Description;

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class UCBacketCart : UserControl
    {
        public string Name{ get; set; }
        public string Description{ get; set; }
        public string Price{ get; set; }
        public Image Image{ get; set; }
        public UCBacketCart(string name, string description, string price, Image image)
        {
            InitializeComponent();
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Image = image;

            lName.Text = Name;
            lPrice.Text = Price;
            rtbDescription.Text = Description;
            pictureBox1.Image = Image;
        }
    }
}

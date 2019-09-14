using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class CoffeeShop : Form
    {
        public CoffeeShop()
        {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            string name, contact, address, order;
            Int32 quantity,Price=0;
            name = nameTextBox.Text;
            contact = contactTextBox.Text;
            address = addressTextBox.Text;
            order = orderComboBox.Text;
            quantity = Convert.ToInt32(quantityTextBox.Text);
            if (order == "Black")
            {
                Price = 120 * quantity;
            }
            else if (order == "Cold")
            {
                Price = 100 * quantity;
            }
            else if (order == "Hot")
            {
                Price = 90 * quantity;
            }
            else if (order == "Reguler")
            {
                Price = 80 * quantity;
            }
            else 
            {
                MessageBox.Show("Please Place An Order");
                return;
            }
            string output="Here is your purchase info:" + Environment.NewLine +"Name:"+ name 
                + Environment.NewLine +"Contact no:"+ contact
                + Environment.NewLine+"Address:"+ address + Environment.NewLine + "you ordered: "
                + quantity.ToString() +" "+order+" Coffee" + Environment.NewLine
                + "Your Payment Bill is: " + Price.ToString();
            richTextBox.Text = output;
        }
    }
}

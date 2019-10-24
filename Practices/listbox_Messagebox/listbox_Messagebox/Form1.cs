using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listbox_Messagebox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> ListBoxCondiments = new List<string>();
            ListBoxCondiments.Add("Apple");
            ListBoxCondiments.Add("SAMSUNG");

            StringBuilder str = new StringBuilder();
            foreach (object selectedItem in ListBoxCondiments)
            {
                str.AppendLine(selectedItem.ToString());
            }
            MessageBox.Show("Your made-to-order Burger will include:" + str, "Custom Burger!");
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

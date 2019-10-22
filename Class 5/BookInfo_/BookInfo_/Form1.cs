using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookInfo_
{
    public partial class Form1 : Form
    {
        Hashtable ht = new Hashtable();
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ht.Add(isbnInputTextBox.Text,bookInputTextBox.Text);
            isbnInputTextBox.Text = string.Empty;
            bookInputTextBox.Text = string.Empty;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            
            
                String showName = (string) ht[Convert.ToString(isbnSearchTextBox.Text)];
                if (showName != null)
                {
                    bookSearchTextBox.Text = showName;
                }
                else
                {
                    MessageBox.Show("Book Not Found");
                }
                         
        }
    }
}

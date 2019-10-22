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

namespace DictionaryUI
{
    public partial class Form1 : Form
    {
        Hashtable ht =new Hashtable();
        private string allDetails;
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            ht.Add(idInputTextBox.Text,detailsTextBox.Text);
            idInputTextBox.Text = string.Empty;
            detailsTextBox.Text = string.Empty;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
          
            string searchedID = (string) ht[idSearchTextBox.Text];
            if (searchedID != null)
            {
                MessageBox.Show(searchedID);
            }
            else
            {
                MessageBox.Show(" Empty ");
            }
            
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            foreach (var i in ht.Keys)
             {
                // MessageBox.Show((string) ht[i]);
                allDetails += " "+(string) ht[i]+ Environment.NewLine;
             }

            MessageBox.Show(allDetails);

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emailKeeper_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> emailList = new List<string>();
        private void addButton_Click(object sender, EventArgs e)
        {
           // List<string> emailList = new List<string>();

            if(emailTextBox.Text.Contains('@') & emailTextBox.Text.Contains('.'))
            {

                int count = Regex.Matches(emailTextBox.Text, "@").Count;
                if ( count == 1 )
                {
                    emailList.Add(emailTextBox.Text);
                    emailListBox.Items.Add(emailTextBox.Text);
                    emailTextBox.Text = String.Empty;
                }
                else
                {
                    MessageBox.Show("Multiple '@' not supported");
                }

            }
            else
            {
                MessageBox.Show("Enter valid email");
            }
            


           // foreach (var i in emailList)
           // {
             //   emailListBox.Items.Add(i);
           //}

        }

        private void emailListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void searchButton_Click(object sender, EventArgs e)
        {
            emailSearchListBox.Items.Clear();
            if (string.IsNullOrWhiteSpace(emailSearchBox.Text))
            {
                MessageBox.Show("Empty search");
                
            }
            else
            {
                foreach (var i in emailList)
                {
                    if (i.Contains(emailSearchBox.Text))
                    {
                        emailSearchListBox.Items.Add(i);
                    }

                }
            }
        }
        
    }
}

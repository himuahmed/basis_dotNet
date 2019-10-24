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

namespace book_keeper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<string, string> bookList = new Dictionary<string, string>();
       
       
        private void addButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(isbnTextBox.Text)==true || string.IsNullOrWhiteSpace(nameTextBox.Text) == true)
            {
                MessageBox.Show("Enter missing values.");

            }
            else
            {
                bookList.Add(isbnTextBox.Text, nameTextBox.Text);
                addListBox.Items.Add(isbnTextBox.Text);
                addListBox.Items.Add(nameTextBox.Text);
                isbnTextBox.Text = string.Empty;
                nameTextBox.Text = string.Empty;
            }

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if(isbn.Checked == true)
            {
                if(string.IsNullOrWhiteSpace(isbnSearchTextBox.Text)== true)
                {
                    MessageBox.Show("Empty Search");
                }
                else
                {
                    foreach(var i in bookList)
                    {
                        if(i.Key == isbnSearchTextBox.Text)
                        {
                            searchListBox.Items.Add(i.Value);
                        }
                    }
                }
            }
            else if(name.Checked == true)
            {
                if (string.IsNullOrWhiteSpace(isbnSearchTextBox.Text) == true)
                {
                    MessageBox.Show("Empty Search");
                }
                else
                {
                    foreach (var i in bookList)
                    {
                        if (i.Value == isbnSearchTextBox.Text)
                        {
                            searchListBox.Items.Add(i.Key);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Select ISBN or Name");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Windows.Forms.PropertyGridInternal;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInfo_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void infoListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            infoListView.View = View.Details;
            infoListView.Columns.Add("Name");
            infoListView.Columns.Add("Contatc");
            infoListView.Columns.Add("Email");
            infoListView.GridLines = true;
            infoListView.FullRowSelect = true;

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ListViewItem item;
            String[] infoArray = new string[3];
            infoArray[0] = nameTextBox.Text;
            infoArray[1] = contactTextBox.Text;
            infoArray[2] = emailTextBox.Text;
            nameTextBox.Text = String.Empty;
            contactTextBox.Text = String.Empty;
            emailTextBox.Text =String.Empty;

            item = new ListViewItem(infoArray);
            infoListView.Items.Add(item);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            infoListView.Clear();
            infoListView.View = View.Details;
            infoListView.Columns.Add("Name");
            infoListView.Columns.Add("Contatc");
            infoListView.Columns.Add("Email");

        }
        
        private void infoListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            if (infoListView.SelectedItems != null)
            {
               // string[] item = new string[3];
                //string item = infoListView.SelectedItems.ToString();
                MessageBox.Show(" "+infoListView.SelectedItems[0].SubItems[0].Text + " "+ infoListView.SelectedItems[0].SubItems[1].Text + " " + infoListView.SelectedItems[0].SubItems[2].Text);
                
                
            }
        }
    }
}

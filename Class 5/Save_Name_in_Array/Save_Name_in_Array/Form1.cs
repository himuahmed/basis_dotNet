using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Save_Name_in_Array
{
    public partial class Form1 : Form
    {
        private List<int> nameList = new List<int>();
        private int count,sum =0;
        public Form1()
        {
            InitializeComponent();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveName_Click(object sender, EventArgs e)
        {

            nameList.Add(Int32.Parse(nameTextBox.Text));
            nameTextBox.Text = String.Empty;
            count = nameList.Count;

        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            foreach (var i in nameList)
            {
                showAllName.Items.Add(i);
                sum = sum + i;

            }

            totalInputTextBox.Text = Convert.ToString(count);
            sumTextBox.Text = Convert.ToString(sum);
        }
    }
}

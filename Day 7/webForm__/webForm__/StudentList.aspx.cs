using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webForm__
{
    public partial class StudentList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          //  ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Save_Click(object sender, EventArgs e)
        {
            List<Student> studentList = new List<Student>();
            Student aStudent = new Student();

            aStudent.FirstName = firstNameTextBox.Text;
            aStudent.LastName = lastNameTextBox.Text;
            aStudent.UserName = userNameTextBox.Text;
            aStudent.RegNo = regNoTextBox.Text;
            aStudent.Email = emailTextBox.Text;
            aStudent.Age = Int32.Parse(ageTextBox.Text);
            if (ViewState["AllStudent"] != null)
            {
                studentList = (List<Student>) ViewState["AllStudent"];
            }
            studentList.Add(aStudent);
            ViewState["AllStudent"] = studentList;

            ClearTextBox();
            message.Text =String.Empty;
            message.Text = "Sudent saved";
            message.ForeColor = Color.Green;
        }
        public void ClearTextBox()
        {
            firstNameTextBox.Text = String.Empty;
            lastNameTextBox.Text = String.Empty;
            userNameTextBox.Text = String.Empty;
            regNoTextBox.Text = String.Empty;
            emailTextBox.Text = String.Empty;
            ageTextBox.Text = String.Empty;
        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            nameListBox.Items.Clear();
            List<Student> newStudentList = new List<Student>();
            newStudentList = (List<Student>) ViewState["AllStudent"];
            if (newStudentList != null)
            {
                foreach (Student student in newStudentList)
                {
                    nameListBox.Items.Add("First Name : " + student.FirstName);
                    nameListBox.Items.Add("Last Name : " + student.LastName);
                    nameListBox.Items.Add("User Name : " + student.UserName);
                    nameListBox.Items.Add("Reg No : " + student.RegNo);
                    nameListBox.Items.Add("Email : " + student.Email);
                    nameListBox.Items.Add("Age : " + student.Age);
                    nameListBox.Items.Add(" ");
                }
            }

        }
    }
}
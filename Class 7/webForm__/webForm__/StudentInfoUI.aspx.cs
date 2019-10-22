using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webForm__
{
    public partial class StudentInfoUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Save_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();
            aStudent.FirstName = firstNameTextBox.Text;
            aStudent.LastName = lastNameTextBox.Text;
            aStudent.UserName = userNameTextBox.Text;
            aStudent.RegNo = regNoTextBox.Text;
            aStudent.Email = emailTextBox.Text;
            aStudent.Age = Int32.Parse(ageTextBox.Text);
            ViewState["Student"] = aStudent;
            ClearTextBox();

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
            Student viewStudent = new Student();
            viewStudent = (Student) ViewState["Student"];

            if (viewStudent != null)
            {
                firstNameLabel.Text = viewStudent.FirstName;
                lastNameLabel.Text = viewStudent.LastName;
                userNameLabel.Text = viewStudent.UserName;
                regNoLabel.Text = viewStudent.RegNo;
                emailLabel.Text = viewStudent.Email;
                ageLabel.Text = viewStudent.Age.ToString();
            }
            else
            {
                message.Text = "Student Info Not Found";
                message.ForeColor = Color.Red;
            }
        }

        protected void studentListButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentList.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VehicleInfo
{
	public partial class VehicleInformationUI : System.Web.UI.Page
	{
		SpeedCalculator aVehicle = new SpeedCalculator();

		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void createButton_Click(object sender, EventArgs e)
		{
            if(String.IsNullOrWhiteSpace(vehicleNameTextBox.Text) == false && String.IsNullOrWhiteSpace(regNoTextBox.Text) == false)
            {
                vehicleErrorLabel.Text = String.Empty;
                aVehicle.vehicleName = vehicleNameTextBox.Text;
                aVehicle.regNo = regNoTextBox.Text;
                ViewState["Vehicle"] = aVehicle;
            }
            else
            {
                vehicleErrorLabel.Text = "Fill the blank field";
                vehicleErrorLabel.ForeColor = System.Drawing.Color.Red;
            }
			
		}

		protected void speedEnterButton_Click(object sender, EventArgs e)
		{
            if(ViewState["Vehicle"] != null && String.IsNullOrWhiteSpace(speedTextBox.Text) ==false)
            {
                showErrorLabel.Text = String.Empty;
                SpeedCalculator newVehicle = (SpeedCalculator)ViewState["Vehicle"];
                newVehicle.speedList.Add(Double.Parse(speedTextBox.Text));
                ViewState["Vehicle"] = newVehicle;
                speedTextBox.Text = string.Empty;
            }
            else
            {
                showErrorLabel.Text = "Fill the blank field properly";
                showErrorLabel.ForeColor = System.Drawing.Color.Red;               
            }
		}

		protected void showButton_Click(object sender, EventArgs e)
		{
			SpeedCalculator nVehicle = (SpeedCalculator)ViewState["Vehicle"];
            if(ViewState["Vehicle"] != null)
            {
                double maxSpeed = nVehicle.GetMaxSpeed();
                double minSpeed = nVehicle.GetMinSpeed();
                double avgSpeed = nVehicle.GetAvgSpeed();
                maxTextBox.Text = maxSpeed.ToString();
                minTextBox.Text = minSpeed.ToString();
                avgTextBox.Text = avgSpeed.ToString();
                vehicleNameTextBox.Text = string.Empty;
                regNoTextBox.Text = string.Empty;
            }



		}
	}
}
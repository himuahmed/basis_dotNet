using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VehicleInfo
{
	[Serializable]
	public class SpeedCalculator
	{
		public string vehicleName, regNo;
		public List<double> speedList=new List<double>();

		public double GetMaxSpeed()
		{
			double max = speedList.Max();
			return max;
		}
		public double GetMinSpeed()
		{
			double min = speedList.Min();
			return min;
		}
		public double GetAvgSpeed()
		{
		
			double avg = speedList.Average();
			return avg;
		}




	}
}
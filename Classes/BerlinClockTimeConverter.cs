﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BerlinClock
{
	public class BerlinClockTimeConverter : ITimeConverter
	{
		public string ConvertTime(string time)
		{
			var timeElements = time.Split(':').Select(el => Convert.ToInt32(el)).ToArray();
			Console.WriteLine("The time:{0}", time);
			return ConvertTime(timeElements[0], timeElements[1], timeElements[2]);
		}

		private string ConvertTime(int hours, int minutes, int seconds)
		{
			return $@"{ConvertSeconds(seconds)}
{ConvertMinutes(minutes)}
{ConvertHours(hours)}";
		}

		private string ConvertSeconds(int timeSecond)
		{
			return timeSecond.ToString();
		}

		private string ConvertMinutes(int minutes)
		{
			return minutes.ToString();
		}

		private string ConvertHours(int hour)
		{
			return hour.ToString();
		}
	}
}
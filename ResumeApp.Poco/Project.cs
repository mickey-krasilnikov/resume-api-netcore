﻿namespace ResumeApp.Poco
{
	public class Project
	{
		public string Client { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public List<string> Roles { get; set; }
		public List<string> Envirnment { get; set; }
		public List<string> TaskPerformed { get; set; }
	}
}
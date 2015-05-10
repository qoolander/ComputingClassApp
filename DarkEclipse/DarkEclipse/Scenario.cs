using System;
using System.Collections.Generic;

namespace DarkEclipse
{
	public class Scenario
	{
		public int ID { get; set; }
		public string Description{ get; set; }
		public List<Option> Options{ get; set; }

		public Scenario ()
		{
			
		}
	}
}


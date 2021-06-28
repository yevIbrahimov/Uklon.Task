using System.Collections.Generic;

namespace Uklon.TestTask1
{
	public class Weather
	{
		public string temperature { get; set; }
		public string wind { get; set; }
		public string description { get; set; }
		public List<Forecast> forecast { get; set; }
	}
}

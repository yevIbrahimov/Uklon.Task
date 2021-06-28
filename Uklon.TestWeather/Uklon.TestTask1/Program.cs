using System.Threading.Tasks;
using System;

namespace Uklon.TestTask1
{
	class Program
	{
		static async Task Main(string[] args)
		{
			var temperature = await new Solution().GetTemperature();

			Console.WriteLine($"Kyiv temperature: {temperature.Item1}");

			Console.WriteLine($"Odesa temperature: {temperature.Item2}");
		}
	}
}

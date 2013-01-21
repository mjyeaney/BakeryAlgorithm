using System;
using System.Threading;

namespace BakeryAlgorithm
{
	public class MainHarness
	{
		/// <summary>
		/// Main entry point for simulation.
		/// </summary>
		public static void Main(string[] args)
		{
			// Initialize the bkery, with a max size.
			var b = new Bakery(8);

			// This user process will fail during the critical section,
			// in order to simulate a failed process with no recovery.
			//new BadUser().Start(8, b);

			// These users represent normal, well-behaved user processes.
			new GoodUser().Start(0, b);
			new GoodUser().Start(1, b);
			new GoodUser().Start(2, b);
			new GoodUser().Start(3, b);

			// add some more user process a little bit later.
			//Thread.Sleep(2000);
			new GoodUser().Start(4, b);
			new GoodUser().Start(5, b);
			new GoodUser().Start(6, b);
			new GoodUser().Start(7, b);


			// Wait
			Console.ReadLine();
		}
	}
}

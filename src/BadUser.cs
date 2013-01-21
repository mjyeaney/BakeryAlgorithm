using System;
using System.Threading;
using System.Threading.Tasks;

namespace BakeryAlgorithm
{
	public class BadUser : IUser
	{
		public void Start(int userId, Bakery b)
		{
			Task.Factory.StartNew(() =>
				{
					var r = new Random();

					Console.WriteLine("Starting BadUser {0}...", userId);

					b.Lock(userId);

					Console.WriteLine("Inside critical section {0}...", userId);

					Thread.Sleep(TimeSpan.FromSeconds(r.Next(1, 3)));

					Console.WriteLine("Exiting without unlocking - FAILURE simulation...");
				});
		}
	}
}


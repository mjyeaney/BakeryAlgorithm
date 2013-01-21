using System;
using System.Threading;
using System.Threading.Tasks;

namespace BakeryAlgorithm
{
	public class GoodUser : IUser
	{
		public void Start(int userId, Bakery b)
		{
			Task.Factory.StartNew(() =>
				{
					var r = new Random();

					Console.WriteLine("Starting GoodUser {0}...", userId);
					
					b.Lock(userId);

					Console.WriteLine("Inside critical section {0}...", userId);

					// Do some silly work, and keep health upto date.
					for (var j=0; j < 100; j++)
					{
						Thread.Sleep(2);
					}

					b.Unlock(userId);

					//throw new Exception();

					Console.WriteLine("Released critical section {0}...", userId);
				})
				.ContinueWith(t =>
				{
					if (t.Exception != null)
					{
						Console.WriteLine("Oops!!!");
					}
				});
		}
	}
}

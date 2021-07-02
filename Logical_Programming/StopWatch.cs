using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading;


namespace Logical_Programming
{
    /// <summary>
    /// To find the elapsetime
    /// </summary>
    class StopWatch
    {
        public static void elapsed()
        {

				Stopwatch stopwatch = new Stopwatch();
				stopwatch.Start();
				for (int i = 0; i < 1000; i++)
				{
					Thread.Sleep(1);
				}
				stopwatch.Stop();

				Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
			
		}
    }
}

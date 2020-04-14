using System;
using System.Threading;

namespace Exercise_1
{

    public class StopWatch
    {
        private DateTime _startTime;
        private DateTime _endTime;

        private bool _running;

        public void Start()
        {

            if(_running)
                throw new InvalidOperationException("Stopwatch is already Running");
               
            
                _startTime = DateTime.Now;
                _running = true;
            
        }

        public void Stop()
        {
            if (!_running)
                throw new InvalidOperationException("Stopwatch is not Running");

            
                _endTime = DateTime.Now;
                _running = false;
            
        }

        public TimeSpan GetInterval()
        {
           
             return _endTime - _startTime;
            
        }
    }
    class Exercise_Stopwatch
    {
        static void Main(string[] args)
        {
            var stopwatch = new StopWatch();

            for(var i=0;i<2;i++)
            {
                stopwatch.Start();

                Thread.Sleep(1000);

                stopwatch.Stop();

                Console.WriteLine("Duration: "+stopwatch.GetInterval());
                Console.WriteLine("Press enter to run the stopwatch one more time .");
                Console.ReadLine();
            }
        }
    }
}

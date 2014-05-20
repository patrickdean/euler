using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Timer
{
    /// <summary>
    /// A simple timer.
    /// </summary>
    public class SimpleTimer
    {
        /// <summary>
        /// Gets the time when the timer was started.
        /// </summary>
        public DateTime StartTime { get; private set; }
        /// <summary>
        /// Gets the time when the timer was stopped.
        /// </summary>
        public DateTime EndTime { get; private set; }
        /// <summary>
        /// Gets the Elapsed time from Start to Stop.
        /// </summary>
        public TimeSpan ElapsedTime { get; private set; }

        public SimpleTimer()
        {

        }

        /// <summary>
        /// Starts the timer.
        /// </summary>
        public void Start()
        {
            StartTime = DateTime.Now;
        }

        /// <summary>
        /// Stops the timer.
        /// </summary>
        public void Stop()
        {
            EndTime = DateTime.Now;
            ElapsedTime += EndTime - StartTime;
        }
        
        /// <summary>
        /// Returns a string that represents the current reading of the timer.
        /// </summary>
        /// <returns>The string.</returns>
        new public string ToString()
        {
            return ElapsedTime.ToString();
        }
    }
}

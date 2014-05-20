using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Timer
{
    /// <summary>
    /// A simple timer.
    /// </summary>
    public static class SimpleTimer
    {
        /// <summary>
        /// Gets the time when the timer was started.
        /// </summary>
        public static DateTime StartTime { get; private set; }
        /// <summary>
        /// Gets the time when the timer was stopped.
        /// </summary>
        public static DateTime EndTime { get; private set; }
        /// <summary>
        /// Gets the Elapsed time from Start to Stop.
        /// </summary>
        public static TimeSpan ElapsedTime
        {
            get
            {
                if (StartTime == null)
                    return TimeSpan.Zero;
                else if (EndTime != null)
                    return EndTime - StartTime;
                else
                    return DateTime.Now - StartTime;
            }
        } 

        /// <summary>
        /// Starts the timer.
        /// </summary>
        public static void Start()
        {
            StartTime = DateTime.Now;
        }

        /// <summary>
        /// Stops the timer.
        /// </summary>
        public static void Stop()
        {
            EndTime = DateTime.Now;
        }
        
        /// <summary>
        /// Returns a string that represents the current reading of the timer.
        /// </summary>
        /// <returns>The string.</returns>
        new public static string ToString()
        {
            return ElapsedTime.ToString();
        }
    }
}

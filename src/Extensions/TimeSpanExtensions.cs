using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSpanExtensions
{
    public static class TimeSpanExtensions
    {
        /// <summary>
        /// Create a timespan for the specified number of days.
        /// </summary>
        /// <param name="days">Length of the timespan in days</param>        
        /// <returns>A timespan for the specified number of days</returns>
        /// <example>3.Days()</example>
        public static TimeSpan Days(this int days)
        {
            return new TimeSpan(days, 0, 0, 0);
        }

        /// <summary>
        /// Create a timespan for the specified number of hours.
        /// </summary>
        /// <param name="days">Length of the timespan in hours</param>        
        /// <returns>A timespan for the specified number of hours</returns>
        /// <example>3.Hours()</example>
        public static TimeSpan Hours(this int hours)
        {
            return new TimeSpan(0, hours, 0, 0);
        }

        /// <summary>
        /// Create a timespan for the specified number of minutes.
        /// </summary>
        /// <param name="days">Length of the timespan in minutes</param>        
        /// <returns>A timespan for the specified number of minutes</returns>
        /// <example>3.Minutes()</example>
        public static TimeSpan Minutes(this int minutes)
        {
            return new TimeSpan(0, 0, minutes, 0);
        }

        /// <summary>
        /// Create a timespan for the specified number of seconds.
        /// </summary>
        /// <param name="days">Length of the timespan in seconds</param>        
        /// <returns>A timespan for the specified number of seconds</returns>
        /// <example>3.Seconds()</example>
        public static TimeSpan Seconds(this int seconds)
        {
            return new TimeSpan(0, 0, 0, seconds);
        }

        /// <summary>
        /// Create a timespan for the specified number of milliseconds.
        /// </summary>
        /// <param name="milliseconds">Length of the timespan in milliseconds</param>        
        /// <returns>A timespan for the specified number of milliseconds</returns>
        /// <example>3.Milliseconds()</example>
        public static TimeSpan Milliseconds(this int milliseconds)
        {
            return new TimeSpan(0, 0, 0, 0, milliseconds);
        }
    }
}

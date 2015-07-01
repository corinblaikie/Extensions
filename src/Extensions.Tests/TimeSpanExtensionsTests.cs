using System;
using Should;
using TimeSpanExtensions;

namespace Extensions.Tests
{
    public class TimeSpanExtensionsTests
    {        
        public void TestDaysExtension()
        {            
            3.Days().ShouldEqual(new TimeSpan(3, 0, 0, 0, 0));
        }
                
        public void TestHoursExtension()
        {
            3.Hours().ShouldEqual(new TimeSpan(0, 3, 0, 0, 0));
        }
                
        public void TestMinutesExtension()
        {
            3.Minutes().ShouldEqual(new TimeSpan(0, 0, 3, 0, 0));
        }

        public void TestSecondsExtension()
        {
            3.Seconds().ShouldEqual(new TimeSpan(0, 0, 0, 3, 0));
        }

        public void TestMillisecondsExtension()
        {
            3.Milliseconds().ShouldEqual(new TimeSpan(0, 0, 0, 0, 3));
        }
    }
}

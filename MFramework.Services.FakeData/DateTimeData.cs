
using System;

namespace MFramework.Services.FakeData
{
    public static class DateTimeData
    {
        public static DateTime GetDatetime()
        {
            DateTime datetime = DateTimeData.GetDatetime(new DateTime(1972, 1, 1), DateTime.Now);
            return datetime;
        }

        public static DateTime GetDatetime(DateTime from, DateTime to)
        {
            TimeSpan range = to - from;
            TimeSpan randTimeSpan = new TimeSpan((long)(NumberData.GetDouble() * (double)range.Ticks));
            return from + randTimeSpan;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silkroski_BOP3.Models
{
    public class DateTime
    {
        #region Properties/Fields

        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Seconds { get; set; }
        public DateTimeKind TimeZone { get; set; }

        #endregion

        #region Constructors

        DateTime()
        {

        }

        DateTime(int year, int month, int day, int hour, int minute, int seconds, DateTimeKind timeZone)
        {
            Year = year;
            Month = month;
            Day = day;
            Hour = hour;
            Minute = minute;
            Seconds = seconds;
            TimeZone = timeZone;
        }

        #endregion
    }
}

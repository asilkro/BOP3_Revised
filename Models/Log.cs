using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silkroski_C969_Revised.Models
{
    public partial class Log
    {
        #region Fields / Properties

        public int EventNumber { get; set; }

        public string EventName { get; set; }

        public DateTime TimeStamp { get; set; }

        public string MessageDetails { get; set; }
        #endregion

        #region Constructors

        public Log()
        {

        }

        public Log(int eventNumber, string eventName, DateTime timeStamp, string messageDetails)
        {
            eventNumber = EventNumber;
            eventName = EventName;
            timeStamp = TimeStamp;
            messageDetails = MessageDetails;
        }


        #endregion
    }
}

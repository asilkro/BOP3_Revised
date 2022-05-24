using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silkroski_C969_Revised.Models
{
    public class Log
    {
        #region Properties / Fields



        #endregion

        #region Constructors

        public Log()
        {

        }

        #endregion

        #region Methods

        public void CreateLogFile()
        {
            string pwd = System.IO.Directory.GetCurrentDirectory();
            DateTime now = DateTime.Now;
            StreamWriter streamWriter = System.IO.File.AppendText(pwd + "LogFile.txt");
            streamWriter.WriteLine("Log file created at {}" + now);
        }

        public void AppendLogFile()
        {
            string message = GetMessage();
            string pwd = System.IO.Directory.GetCurrentDirectory();
            DateTime now = DateTime.Now;
            StreamWriter streamWriter = System.IO.File.AppendText(pwd + "LogFile.txt");
        }

        private string GetMessage() // TODO: Make a GetMessage
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}

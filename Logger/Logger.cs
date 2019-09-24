using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    /// <summary>
    /// 
    /// </summary>
    public class Logger
    {
        public List<string> Content;
        private string v;
        private string currentDateString;

        public Logger()
        {
            
        }
        /// <summary>
        /// 
        /// </summary>
        public Logger(string v)
        {

        }

        public Logger(string v, string currentDateString)
        {
            this.v = v;
            this.currentDateString = currentDateString;
        }

        public void WriteEntry(string expectedLevel, string expectedMessage)
        {
            throw new NotImplementedException();
        }
    }
}

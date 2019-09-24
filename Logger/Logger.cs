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
        private List<string> content;
        private string directory;
        private string date;
        public List<string> Content {
            get
            {
                bool header = true;
                content = new List<string>();
                using (StreamReader sw = new StreamReader(directory))
                {
                    string line;
                    while ((line = sw.ReadLine()) != null) {
                        if (header)
                        {
                            header = false;
                        }
                        else
                        {
                            content.Add(line);
                        }
                    }
                }
                return content;
            }
        }
        //private string currentDateString;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="directoryToSave"></param>
        /// <param name="currentDateString"></param>
        public Logger(string directoryToSave, string currentDateString)
        {
            directory = directoryToSave + "\\logger_" + currentDateString + ".log";
            date = DateTime.Today.ToString("yyyyMMdd");
            string msgToWrite = "timestamp\tlevel\tmessage";
            using (StreamWriter sw = new StreamWriter(directory))
            {
                sw.WriteLine(msgToWrite);
            }

        }

        public void WriteEntry(string expectedLevel, string expectedMessage)
        {
            string msgToWrite=date + "\t"+ expectedLevel + "\t"+ expectedMessage;
            using (StreamWriter sw = new StreamWriter(directory,true))
            {
                sw.WriteLine(msgToWrite);
            }
        }
    }
}

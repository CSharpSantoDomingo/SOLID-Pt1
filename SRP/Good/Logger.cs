using System.IO;

namespace SRP.Good
{
    public class Logger
    {
        private readonly StringWriter _logger;

        public Logger()
        {
            _logger = new StringWriter();
        }

        public void WriteToLog(string value)
        {
            _logger.WriteLine(value);
        }

        public void SaveLog()
        {
            //Do stuff for Save log to File
        }
    }
}

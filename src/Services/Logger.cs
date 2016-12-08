using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services
{
    /// <summary>
    /// This class is designed to perform a basic logging function.
    /// In the future, we might want to expand our logging capabilities. 
    /// 
    /// Currently, this class doesn't follow SOLID and would require too much modification to extext. 
    /// It violates the Open Close Principle. 
    /// 
    /// Please refactor this method and provide tests in Services.UnitTests.LoggerTests.LogShould.
    /// 
    /// 
    /// Hint:
    /// 
    /// public class ConsoleLogger : IMessageLogger {}
    /// public class QueueLogger : IMessageLogger {}
    /// </summary>
    public class Logger
    {
        IMessageLogger _messageLogger;

        public Logger(IMessageLogger messageLogger)
        {
            _messageLogger = messageLogger;
        }

        public void Log(string message)
        {
            _messageLogger.Log(message);
        }
    }

    public interface IMessageLogger
    {
        void Log(string message);
    }

    public class ConsoleLogger : IMessageLogger
    {
        public void Log(string message)
        {
            if (message == "")
            {
                throw new Exception("Message must not be zero length string.");
            }
            else
            {
                Console.WriteLine(message);
            }
        }
    }

    public class QueueLogger : IMessageLogger
    {
        public void Log(string message)
        {
            if (message == "")
            {
                throw new Exception("Message must not be zero length string.");
            }
            else
            {
                // Code to send message to printer
            }
        }
    }
}

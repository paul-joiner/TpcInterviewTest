using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moq;
using Xunit;

namespace Services.UnitTests.LoggerTests
{
    public class LogShould
    {
        [Fact]
        public void Call_Log_with_message_ConsolePass()
        {
            IMessageLogger messageLogger = new ConsoleLogger();
            Logger logger = new Logger(messageLogger);

            logger.Log("Log to Console: " + DateTime.Now.ToString());
            //throw new NotImplementedException();            
        }

        [Fact]
        public void Call_Log_with_message_ConsoleFail()
        {
            IMessageLogger messageLogger = new ConsoleLogger();
            Logger logger = new Logger(messageLogger);

            logger.Log("");
            throw new NotImplementedException();
        }

        [Fact]
        public void Call_Log_with_message_QueuePass()
        {
            IMessageLogger messageLogger = new QueueLogger();
            Logger logger = new Logger(messageLogger);

            logger.Log("Log to Queue: " + DateTime.Now.ToString());
            //throw new NotImplementedException();            
        }

        [Fact]
        public void Call_Log_with_message_QueueFail()
        {
            IMessageLogger messageLogger = new QueueLogger();
            Logger logger = new Logger(messageLogger);

            logger.Log("");
            throw new NotImplementedException();
        }
    }
}

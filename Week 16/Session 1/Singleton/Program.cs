using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    // eager loading singleton
    public class LoggingClass
    {
        private LoggingClass()
        {

        }

        private static LoggingClass instance = new LoggingClass();

        public static LoggingClass GetInstance()
        {
            return instance;
        }

        public void OpenLogFile(string logFileName)
        {

        }

        public void WriteToLog(string logInfo)
        {

        }
    }

    // lazy loading Singleton
    public class BossCreature
    {
        private BossCreature()
        {

        }

        private static BossCreature instance;

        public static BossCreature Instance
        {
            get
            {
                if( instance == null)
                {
                    instance = new BossCreature();
                }

                return instance;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            LoggingClass logger = LoggingClass.GetInstance();

            logger.OpenLogFile(args[0]);
            logger.WriteToLog(args[1]);
        }
    }
}

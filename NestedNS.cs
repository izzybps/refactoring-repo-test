// A skeleton of a C# program
using System;
namespace ParentNamespace
{
    namespace NestedNamespace
    {
        class Program
        {
            public Program(string[] args)
            {
                _logger = LogFactory.MakeServiceLog(typeof(BimboB2BServices));
                _logger.Info("Service B2B Started");
                InitializeComponent();
            }
            private const string PARAM_SCHEDULED_TIME = "ScheduledTime";
            private const string PARAM_SCHEDULED_TIME_RESTOCK = "ScheduledTimeRestock";

            static void Main(string name, string age, string[] args)
            {
                //Your program starts here...
                Console.WriteLine($"Hello world! My name is {name} and I am {age} years old.");
            }
        }
        class TestClass
        {
            public TestClass()
            {
                _logger = LogFactory.MakeServiceLog(typeof(BimboB2BServices));
                _logger.Info("Service B2B Started");
                InitializeComponent();
            }
            private const string PARAM_INTERVAL_MINUTES = "IntervalMinutes";
            private const string PARAM_INTERVAL_MINUTES_RESTOCK = "IntervalMinutesRestock";
            static void Main(string name, string age, string[] args)
            {
                //Your program starts here...
                Console.WriteLine($"Hello world! My name is {name} and I am {age} years old.");
            }
        }
    }
}
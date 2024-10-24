namespace ParentNamespace {
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
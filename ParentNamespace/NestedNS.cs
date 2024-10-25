// A skeleton of a C# program
using System;
using BimboB2B.CrossDomain;
using BimboB2B.Model.Models;
using BimboB2B.Model.Models.DTO;
using BimboB2B.Model.Utils;
namespace ParentNamespace
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
    public interface ILoadData
    {
        void LoadDataLayer(DataSet ds, string cIDCompany, int cIDImport, out string errorMessage, string origemPedido);
    }
    public class LoadDataFactory
    {
        public const string DINADEL = "DINADEL";
        public const string B2B = "B2B";
        public const string B2BNC = "B2BNC";

        private static readonly Dictionary<string, Func<EFContext, EFContextBO, ILoadData>> dataLoaders =
            new Dictionary<string, Func<EFContext, EFContextBO, ILoadData>>(StringComparer.OrdinalIgnoreCase)
            {
                { DINADEL, (context, contextBO) => new LoadDataDinadel(context, contextBO) },
                { B2B, (context, contextBO) => new LoadDataB2B(context, contextBO) },
                { B2BNC, (context, contextBO) => new LoadDataB2BNC(context, contextBO) }
            };

        public static ILoadData Build(string origin, EFContext context, EFContextBO contextBO)
        {
            if (dataLoaders.TryGetValue(origin, out var loader))
            {
                return loader(context, contextBO);
            }
            return null;
        }
    }
}
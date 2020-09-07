using System;

namespace Adapter
{
    class Program
    {

        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new TaLogger());
            productManager.Save();
            ProductManager productManager1 = new ProductManager(new Log4NetAdapter());
            productManager1.Save();
        }
    }
    class ProductManager
    {
        private ILogger _logger;
        public ProductManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Save()
        {
            _logger.Log("User Data");
            Console.WriteLine("Saved");
        }
    }
    interface ILogger
    {
        void Log(string message);
    }

    class TaLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Ta Logger Message : {message}");
        }
    }

    //NugetPack
    class Log4Net
    {
        public void LogMessager(string message)
        {
            Console.WriteLine($"Log with Log4Net : {message}");
        }
    }

    class Log4NetAdapter : ILogger
    {
        public void Log(string message)
        {
            Log4Net log4net = new Log4Net();
            log4net.LogMessager(message);
        }
    }
}

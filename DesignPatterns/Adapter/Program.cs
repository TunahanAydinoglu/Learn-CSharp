using System;

namespace Adapter
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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
}

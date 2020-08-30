using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerManager = CustomerManager.CreateAsSingleton();
            customerManager.Save();
        }
    }

    class CustomerManager
    {
        static CustomerManager _customerManager;
        private CustomerManager()
        {

        }
        //public static CustomerManager CreateAsSingleton()
        //{
        //    if(_customerManager == null)
        //    {
        //        _customerManager = new CustomerManager();
        //    }
        //    return _customerManager;
        //}
        public static CustomerManager CreateAsSingleton()
        {
            return _customerManager ?? (_customerManager = new CustomerManager());
        }

        public void Save()
        {
            Console.WriteLine("Saved Singleton");
        }
    }
}

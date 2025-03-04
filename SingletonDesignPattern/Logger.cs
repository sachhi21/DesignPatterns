using DesignPatterns.FactoryMethodDesign;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SingletonDesignPattern
{
    public  class Logger
    {
       public static readonly Lazy<Logger>? _instance = new Lazy<Logger>( () => new Logger());

        private Logger() { }

        public static Logger Instance = _instance.Value;

       public void log(string message)
        {
            Console.WriteLine(message);
        }

        public void log(CreditCard creditCard)
        {
            Console.WriteLine("Card Type: " + creditCard.GetCardType().ToString());
            Console.WriteLine("Amount:" +creditCard.GetAmount());
            Console.WriteLine("Limit :" + creditCard.getLimit());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethodDesign.models
{
    public class MoneyBackCreditCard : CreditCard
    {
        public int GetAmount()
        {
            return 3333;
        }

        public string GetCardType()
        {
            return "MoneyBack";
        }

        public int getLimit()
        {
            return 30000;
        }
    }
}

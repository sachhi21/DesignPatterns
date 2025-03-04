using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethodDesign.models
{
    public class TitaniumCreditCard : CreditCard
    {

        public int GetAmount()
        {
            return 10000;
        }

        public string GetCardType()
        {
            return "titanium";
        }

        public int getLimit()
        {
            return 100000;
        }
    }

}

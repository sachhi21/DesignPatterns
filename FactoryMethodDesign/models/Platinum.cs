using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethodDesign.models
{
    public class Platinum : CreditCard
    {

        
        public int GetAmount()
        {
            return 103000;
        }

        public string GetCardType()
        {
            return "Platinum";
        }

        public int getLimit()
        {
            return 4002000;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethodDesign
{
    public interface CreditCard 
    {
        int GetAmount();
        int getLimit();
        string GetCardType();
    }
}

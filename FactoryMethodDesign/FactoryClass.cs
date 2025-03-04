using DesignPatterns.FactoryMethodDesign.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethodDesign
{
 

    public class FactoryClass(string cardType)
    {
        public static CreditCard CreateCreditCard(string cardType)
        {

            if(cardType == null)
                new ArgumentNullException(cardType);


            return cardType.ToLower() switch
            {

                "moneyback" => new MoneyBackCreditCard(),
                "titanium" => new TitaniumCreditCard(),
                "platinum" => new TitaniumCreditCard(),
                _ => throw new ArgumentException("Invalid card Type")

            };
        }
    }
}

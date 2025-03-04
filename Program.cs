// See https://aka.ms/new-console-template for more information
using DesignPatterns.FactoryMethodDesign;
using DesignPatterns.SingletonDesignPattern;

class Program
{

    public static void Main(string[] args)
    {
       
        Logger log = Logger.Instance;
        log.log("Applcation started");
        Console.WriteLine("Fetch Card Type: MoneyBack,Titanium, Platinum");
        string? cardtype = Console.ReadLine();


        try
        {
            CreditCard creditCard = FactoryClass.CreateCreditCard(cardtype);
            log.log(creditCard);
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }
        finally
        {
            log.log("Applcation Ended");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitecBank
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int tries = 3;

            try
            {
                do
                {
                    Console.WriteLine("Enter your pin");
                    int pin = Convert.ToInt32(Console.ReadLine());
                    Bank bank = new Bank();

                    bank.setPin(pin);
                    bool isValid = bank.validatePin();

                    if(isValid)
                    {
                        Console.WriteLine("Specify the type of transaction you wish to perform\n\n1 = Deposit\n2 = Withdrawal");
                        int transType = int.Parse(Console.ReadLine());

                        if(transType == 1)
                        {
                            Console.WriteLine("Please specify the amount you wish to deposit");
                            double amount = double.Parse(Console.ReadLine());
                            double newBal = bank.Deposit(amount);

                            Console.WriteLine("\n\nYour new balance is R" + newBal);
                        }
                        else if(transType == 2)
                        {
                            Console.WriteLine("Please specify the amount you wish to withdraw");
                            double amount = double.Parse(Console.ReadLine());
                            double newBal = bank.Withdraw(amount);

                            Console.WriteLine("\n\nYour new balance is R" + newBal);
                        }
                        else
                        {
                            Console.WriteLine("\n\nInvalid selection!!!!!!!");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Error: \nWrong pin!!!!!!!");
                        tries--; 
                    }
                }
                while (tries != 0);
            }
            catch(Exception ge)
            {
                Console.WriteLine("\n\nError: " + ge.Message);
            }
            Console.ReadKey();
        }
    }
}

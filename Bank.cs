using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitecBank
{
    public class Bank
    {
        private int pin = 3445;
        private double balance = 25000;

        private int userPin;

       //==
       public  void setPin(int p)
       {
            this.userPin = p;
       }

       //==
       public int getPin()
       {
            return userPin;
       }

        //==
        public bool validatePin()
        {
            bool isValid = false;

            if(getPin() == pin)
            {
                isValid = true;
            }
            return isValid;
        }

        //==
        public double Deposit(double amount)
        {
            balance =  balance + amount;
            return balance;
        }

        //==
        public double Withdraw(double amount)
        {
            balance =  balance - amount;
            return balance;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSoftwareSystem
{

    public interface IPayable
    {
        void Deposit(double amount);
        void Withdraw(double amount);
        void CheckBalance();
    }
    public class Employee : IPayable
    {
        public double balance { get; set; }
        //public employee(double _initialbalance)
        //{
        //    balance = _initialbalance;
        //}
        //double balance;

        public void Deposit(double amount)
        {
            
            if (amount <= 0)
            {
                throw new NotImplementedException("Invalid Deposit Amount");
            }
            else
            {
                balance = balance + amount;
            }
           
        }

        public void Withdraw(double amount)
        { 
        if (amount <= 0 || amount > balance)
        
        {
            throw new NotImplementedException("Invalid Withdraw Amount");
        }
            else
            {
                balance = balance - amount;
            }
    }

        public void CheckBalance()
        {
            Console.WriteLine("Balance:" +balance);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_ConstructorsMethodsOverloading
{
    internal class BankAccount
    {
        //Fields
        string _accountNumber;
        string _customerName;
        double _balance;


        //Properties
        public string AccountNumber { get => _accountNumber; protected set => _accountNumber = value; }
        public string CustomerName { get => _customerName; set => _customerName = value; }
        public double Balance { get => _balance; protected set => _balance = value; }


        //Constructors
        public BankAccount(string accountNumber, string customerName, double balance)
        {
            AccountNumber = accountNumber;
            CustomerName = customerName;
            Balance = balance;
        }

        //Deposit
        public virtual void Deposit(double amount)
        {
            if (IsAmtPositive(amount))
            {
                _balance += amount;
            }
        }

        //Withdraw
        public virtual bool Withdraw(double amount)
        {
            if(IsAmtPositive(amount) && CheckBalance(amount))
            {
                _balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }


        //Validation- Bool to ensure the amount to deposit is positive so the bank doesn't go out of business
        private bool IsAmtPositive(double amount)
        {
            return amount > 0;
        }

        //Validation- Bool to check balance is enough to cover
        private bool CheckBalance(double amount)
        {
            return amount <= _balance;
        }

        //override to string
        public override string ToString()
        {
            return $"{_accountNumber} - {_customerName} - Current Balance: {_balance:c2}";
        }
    }
}

// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 
namespace MultiThreading
{
    // Without Interlocking
    public class BankAccount
    {
        private static decimal _balance;
       
 
        public BankAccount(decimal initialBalance){
            _balance  = initialBalance;
        }
 
        // Deposit money into the account
 
        public void Deposit(object amount){
            Console.WriteLine($"Depositing {amount:C}");
            _balance += (decimal)amount;
            Console.WriteLine($"New Balance: {_balance:C}");
        }
        // Withdraw money from the account
 
        public void Withdraw(object amount){
            if(_balance>=(decimal)amount){
                Console.WriteLine($"Withdrawing {amount:C}");
                _balance -=(decimal) amount;
                Console.WriteLine($"New balance: {_balance:C}");
            }
            else{
                Console.WriteLine("Insufficient Balance!");
            }
        }
 
        public decimal GetBalance(){
            return _balance;
        }
       
    }
}
 
/* create a class called accounts which has data members like Account no, Custmor name,
 Account type,Transaction type(D/W),ammount ,balance D-deposite W-withdrawl */ 
  
using System;

namespace Accounts
{
     
      enum TransactionType { Deposit, Withdrawl };
        class Accounts
        {
            private int accountNo, amount, balance;
            private String customerName, accountType;
            private char transactionType;
            public Accounts(int accountNo, String customerName, String accountType, int balance)
            {
                this.accountNo = accountNo;
                this.customerName = customerName;
                this.accountType = accountType;
                this.balance = balance;
            }
            public void setTransactionType(TransactionType transactionType)
            {
                if (transactionType == TransactionType.Deposit) this.transactionType = 'D';
                else this.transactionType = 'W';
            }
            public char getTransactionType()
            {
                return this.transactionType;
            }
            public void showData()
            {
                Console.WriteLine("Account No: " + accountNo);
                Console.WriteLine("Customer Name: " + customerName);
                Console.WriteLine("Transaction Type: " + transactionType);
                Console.WriteLine("Amount(to be credit/debit): " + amount);
                Console.WriteLine("Balance: " + balance);
            }
            public void credit(int amount)
            {
                this.amount = amount;
                this.balance = balance + amount;
            }
            public void debit(int amount)
            {
                this.amount = amount;
                if (amount > balance)
                {
                    Console.WriteLine("OOPS! Transaction fail due to low balance");
                    return;
                }
                this.balance = balance - amount;
            }
        }
        class psp
        {
             static void Main(string[] args)
            {
                Console.WriteLine("Enter the name: ");
                String name = Console.ReadLine();
                Console.WriteLine("Enter the account type: ");
                String accType = Console.ReadLine();
                Console.WriteLine("Enter the account number: ");
                int accNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the balance: ");
                int balance = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the transaction type: ");
                char transactionType = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Enter the amount(Credit/Debit) ");
                int amount = Convert.ToInt32(Console.ReadLine());
                Accounts a = new Accounts( accNo,  name, accType,  balance);
                if (transactionType =='D') a.setTransactionType(TransactionType.Deposit);
                else a.setTransactionType(TransactionType.Withdrawl);
                char tt = a.getTransactionType();
                if (tt == 'D') a.credit(amount);
                if (tt == 'W') a.debit(amount);
                a.showData();
            }
        }
    }
/* -------OUTPUT------
 Enter the name:
shivam
Enter the account type:
salary
Enter the account number:
123456789
Enter the balance:
5000
Enter the transaction type:
D
Enter the amount(Credit/Debit)
5000
Account No: 123456789
Customer Name: shivam
Transaction Type: D
Amount(to be credit/debit): 5000
Balance: 10000 
*/


/* Write a class called LoanProcess with Loan_No, Customer Name, 
 LoanAmount, EMI_Amount, Account_Balance as its members. 
 Create a method calculate_EMI() for the LoanAmount, with the rate of 
interest as 13 % for a total of 3 years and store it in the EMI_Amount.
The rest of the information to be passed through constructors.
Write another function CheckBalance() which checks if the Account_Balance is
less than the EMI_AMount.If yes then throw a custom exception.Display 
" Not Sufficient Balance to repay Loan" in the finally. 
Give explanatory comments.*/

using System;

namespace _28janprj
{
    
    class LoanException : ApplicationException
        { public LoanException(string msg) : base(msg) { }
        } 
        class LoanProcess { 
            public int LoanNo; public string cname; 
            public int amount; public double emi_amount; public int bal; 
            public void calculate_EMI(int amount) {
                emi_amount = amount * 0.13 * 3; }
            public void CheckBalance(int bal) {
                if (bal < emi_amount) { 
                    throw (new LoanException("Not Sufficient Balance to Repay Loan Amount"));
                } else { Console.WriteLine("Congratulation! Loan Process Successful");
                } 
            }
        }  class Class02
        {
            static void Main(string[] args) {
                Console.WriteLine("Enter the Loan Amount:"); 
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Balance:");
                int b = Convert.ToInt32(Console.ReadLine());
                LoanProcess lp = new LoanProcess(); lp.calculate_EMI(a);
                lp.CheckBalance(b); 
            }
        }
    }

/*---OUTPUT----
Enter the Loan Amount:
400
Enter the Balance:
1

Unhandled Exception: _28janprj.LoanException: Not Sufficient Balance to Repay Loan Amount
*/
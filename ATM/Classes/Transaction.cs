using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;

namespace ATM.Classes
{
    class Transaction
    {
        

        public void Balance(Account ac)
        {
            Console.Clear();
            Console.WriteLine("Your balance is: RD$" + ac.balance);
            Console.ReadKey();
            
        }
       
        public void Withdrawal(Account ac)
        {
            int amount;
            var bills = new[] { 100, 200, 500, 1000, 2000 }; 
            
            Regex rx = new Regex(@"^[1-9]+[0-9]*00$");
            Console.WriteLine("Enter amount. \n Withdrawal must be multiples of 100");
            amount = Int32.Parse(Console.ReadLine());
            Match m = rx.Match(amount.ToString());

            if (m.Success && amount <= ac.balance)
            {
                Console.WriteLine("Balance: RD$" + (ac.balance - amount));
                foreach (var bill in bills.OrderByDescending(e => e))
                {
                    int count = amount / bill;
                    amount = amount % bill;
                    if(count!=0)
                        Console.WriteLine("{0} {1} Note", count, bill);

                    
                }

                
            }
            else if(amount > ac.balance)
            {
                Console.Clear();
                Console.WriteLine("Insifficient Funds! \n Please enter a new amount");
                Withdrawal(ac);

            }
            else
            {
                Console.Clear();
                Withdrawal(ac);
            }
                

            Console.ReadKey();
           
        }
    }
}

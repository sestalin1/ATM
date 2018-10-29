using System;
using System.Collections.Generic;
using System.Text;


namespace ATM.Classes
{
    class Manager
    {



        public void Admin()
        {
            Account account1 = new Account(101, 10000, "pin", "Pedro Lora");
            Account account2 = new Account(102, 20000, "pin", "Juana Marte");
            Account[] accounts = new Account[] { account1, account2 };

            

            int accountID;
            
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome \n Please insert your ATM card");
                accountID = Int32.Parse(Console.ReadLine());
                AccountChecker(accounts, accountID);

            }
            while (1 == 1);

        }

        void PINChecker(Account ac)
        {
            string pin;
            int counter = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Please enter your PIN");
                pin = Console.ReadLine();

                if (ac.PIN == pin)
                { 
                    TransactionMenu(ac);
                    break;
                }
                else
                    counter++;
            }
            while (counter < 3);
            Console.Clear();
            Console.WriteLine("Invalid ATM card, it will be retained.");

        }

        void AccountChecker(Account[] accounts, int accountID)
        {
            

            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i].ID == accountID)
                {
                    PINChecker(accounts[i]);

                    break;
                }

            }
            
            
        }

        void TransactionMenu(Account ac)
        {
           

            int option;
            Transaction t = new Transaction();
            do
            {

                Console.Clear();
                Console.WriteLine("Select transaction:");
                Console.WriteLine("     1.    balance>");
                Console.WriteLine("     2. withdrawal>");
                Console.WriteLine("To cancel press 0");
                option = Int32.Parse(Console.ReadLine());

                switch (option)
                {

                    case 1:
                        t.Balance(ac);
                        break;
                    case 2:
                        Console.Clear();
                        t.Withdrawal(ac);
                        break;
                    case 0:
                        return;
                    default:
                        TransactionMenu(ac);
                        break;

                }
            }
            while (1== 1);
            
        }

    }
}

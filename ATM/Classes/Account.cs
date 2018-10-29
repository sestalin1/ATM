using System;
using System.Collections.Generic;
using System.Text;

namespace ATM.Classes
{
    class Account
    {
        public int ID;
        public double balance;
        public string PIN;
        public string name;


        public Account(int id, double balanc, string pin, string Name)
        {
            ID = id;
            balance = balanc;
            PIN = pin;
            name = Name;


        }

        

        

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_hajyahia_yazan.Banckapp
{
    class Account
    {
        private Owner owner;
        private double balance;
        private int overDraft;
        private const int max_overdraft = 90_000;


        public Account(Owner owner,double balance,int overDraft)
        {
            this.owner = owner;
            this.balance = balance;
            this.overDraft = overDraft;
        }

        public Owner GetOwner()
        {
            return owner;
        }
        public double GetBalance()
        {
            return balance;
        }
        public int GetOverdraft()
        {
            return overDraft;
        }

        public void SetOverdraft(int overdraft)
        {
           if (overdraft > max_overdraft)
            {
                Console.WriteLine("the max over draft ammount is - "+ max_overdraft);
            }
            else
            {
                this.overDraft = overdraft;
            }
        }
        public void Deposit(double ammount)
        {
            balance += ammount;
        }

        public void Withdraw(double Witherdraw)
        {
            if(balance-Witherdraw < overDraft * -1)
            {
                Console.WriteLine("you cannot overdraw more thean the overdraft");
            }
            else
            {
                balance -= Witherdraw;
            }
        }


    }
}

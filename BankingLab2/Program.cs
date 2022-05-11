using DocumentFormat.OpenXml.Office2010.Excel;
using System;
namespace BankingAccount
{
    //Abstract part which I use abstract class named Account
    abstract class Account
    {
        // Encapsulation : Id, Type, customerId, Balance are protected so that other users do not have access to modify these.
        private int Id { get; set; }
        public string Type { get; set; }
        private int customerId { get; set; }
        double Balance { get; set; }
        private int AccountNumber = 1;
        public virtual void ShowAccountInformation()
        {
            Console.WriteLine("Account");
        }
    }

    //Inheritance,SavingAccount at line 21 inherits Account
    public class SavingAccount : Account   
    {
        // Do not need to announce anything Account still can inherit from SavingAccount
        public SavingAccount(int id, int customerid, double balance)
        {
            Id = id;
            Type = "Saving";
            customerId = customerid;
            Balance = balance;
            AccountNumber++;
        }
        //Polymorphism(Line 33-35)This means they can share a same function called ShowAccountInformation(input) through override, it can be output like "Saving Account"behind the Console.Writeline
        public override SavingAccount ShowAccountInformation()
        {
            Console.WriteLine("Saving Account");
        }
    }
    //Inheritance CheckingAccount inherits Account at line 39
    public class CheckingAccount : Account
    {
        public CheckingAccount(int id, int customerid, double balance)
        {
            //Encapsulation Five properties combine and protect it from outsider's access 
            Id = id;
            Type = "Checking";
            customerId = customerid;
            Balance = balance;
            AccountNumber++;
        }
        //the outsiders cannot access through encapsulation 
        public override CheckingAccount ShowAccountInformation()
        {
            Console.WriteLine("Checking Account");
        }
    }
}

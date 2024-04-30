using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritance2
{
    public class AccountInfo:PersonalInfo

    {
        
        public int AccountNumber{get;set;}
        public string Branch{get;set;}
        public string IFSC{get;set;}
        public int Balance{get;set;}
        //Constructor
        public AccountInfo(string name,string fatherName,long phoneNumber,string mail,DateTime dob,string gender,int accountNumber,string branch,string ifsc,int balance):base(name,fatherName,phoneNumber,mail,dob,gender)
        {
            AccountNumber=accountNumber;
            Branch=branch;
            IFSC=ifsc;
            Balance=balance;
        }
        //Methods
        public void ShowAccountInfo()
        {
            Console.WriteLine($"Name : {Name}\n\nFatherName : {FatherName} \nPhoneNumber : {PhoneNumber}\nMail : {Mail} \nDOB : {DOB}  \nGender : {Gender} \nRegisterNo : {AccountNumber}\nBranch : {Branch} \nIFSC CODE : {IFSC} \nBalance : {Balance}");
        }

        public void Deposit()
        {
            Console.Write("Enter deposit amount : ");
            int deposit=int.Parse(Console.ReadLine());
            Balance=Balance+deposit;
            Console.WriteLine("Your balance is "+Balance) ;
        }
        public void  Withdraw()
        {
             Console.Write("Enter withdraw amount : ");
            int withdraw=int.Parse(Console.ReadLine());
            Balance=Balance-withdraw;
             Console.WriteLine("Your balance is "+Balance) ;
        }
        public void ShowBalance()
        {
             Console.WriteLine(Balance);
        }
    }
}
using System;
namespace SingleInheritance2 
{
    class Program 
    {
        public static void Main(string[] args)
        {
             PersonalInfo personal=new PersonalInfo("Karthika","Ravi",873573347,"Rk@gmail.com",new DateTime(09/06/2002),"female");
             AccountInfo account=new AccountInfo(personal.Name,personal.FatherName,personal.PhoneNumber,personal.Mail,personal.DOB,personal.Gender,1234,"tvr","IF1001",20230);
             account.ShowAccountInfo();
             account.Deposit();
             account.Withdraw();
             account.ShowBalance();
        }
    }
}

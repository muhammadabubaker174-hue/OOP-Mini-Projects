// Smart Banking Account System
using System;
class Bank
{
    private string userName;
    private double balance;
    private int age;
    private int accountNumber;
    private static int Track=0;
    public Bank (string userName,int age , int accountNumber, double balance)
    {
        this.userName=userName;
        this.age=age;
        this.accountNumber=accountNumber;
        this.balance=balance;
        Track++;
    }
    public void depositAmount(double deposit)
    {
        if (deposit <= 0)
        {
            Console.WriteLine("Negative Amount Cannot be Deposited !!!!!! ");
            return ;
        }
        balance+=deposit;
        Console.WriteLine(" --------  Amount Deposited Successfully -------");
        GetAccountDetails();     
    }
    public void WithdrawAmount(double amount)
    {
        if(amount <= 0)
        {
           Console.WriteLine("Wrong Amount !!!!!!!"); 
           return ;   
        }
        if(amount > balance)
        {
            Console.WriteLine("Insufficient Balance !!!!!!");
            return ;
        }
        balance-=amount;
        Console.WriteLine("  -------- Amount Withdraw Successfully ----------");
        GetAccountDetails();
    }
    public static void GetTrackAccount()
    {
        Console.WriteLine($"Total Accounts = {Track}");
    }
    public void GetAccountDetails()
    {
        Console.WriteLine($"User Name  : {userName}");
        Console.WriteLine($"Account Number : {accountNumber}");
        Console.WriteLine($"Balance : {balance}");
        Console.WriteLine($"Age : {age}");
    }
}
class Program
{
     static void Main()
    {
        Bank U1 = new Bank("Name",19,2222220,500000);
        U1.GetAccountDetails();
        U1.depositAmount(6000);
        U1.WithdrawAmount(69000);
        Bank.GetTrackAccount();
    }
}




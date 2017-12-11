using Bank.Models;
using Bank.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bank.ConsoleApp
{
   public class BankATMController
    {
        public static Account CurrentUserAccount { get; set; }

        public static void Start()
        {
            Menu();
            string menuChoice = Console.ReadLine();
            while (menuChoice != "1")
            {
                switch (menuChoice)
                {
                    case "1":
                        Deposit();
                        Console.Clear();
                        Menu();
                        menuChoice = Console.ReadLine();
                        break;

                    case "2":
                        Withdrawal();
                        Console.Clear();
                        Menu();
                        menuChoice = Console.ReadLine();
                        break;

                    case "3":
                        Console.Clear();
                        Thread.Sleep(5000);
                        Console.Clear();
                        Menu();
                        menuChoice = Console.ReadLine();
                        break;

                    case "4":
                        Console.Clear();
                        LogIn();
                        Console.Clear();
                        Menu();
                        menuChoice = Console.ReadLine();
                        break;

                    case "5":
                        Console.Clear();
                        NewCustomerInfo();

                        break;

                    case "6":
                        Console.Clear();
                        Console.WriteLine("Goodbye.");
                        break;

                    default:
                        break;
                }

            }

        }

        public static void NewCustomerInfo()
        {
            Console.WriteLine("Type first name");
            string userFirstName = Console.ReadLine();

            Console.WriteLine("Type last name");
            string userLastName = Console.ReadLine();

            Customer user =
                new Customer
                {
                    FirstName = userFirstName,
                    LastName = userLastName
                };

            CustomerService svc = new CustomerService();
            svc.CreateCustomer(user);
            NewAccountInfo(user.CustomerID);
        }


        //public static void NewAccountInfo(int id)
        //{
        //    Console.WriteLine("Which kind of account would you like?");
        //    Console.WriteLine("1 -- Checking");
        //    Console.WriteLine("2 -- Savings");
        //    string userType = Console.ReadLine();

        //    Console.WriteLine("What would you like your pin to be?");
        //    string userPin = Console.ReadLine();

        //    Console.WriteLine("What would you like your account number to be?");
        //    string userAccountNumber = Console.ReadLine();

        //    Account accounts =
        //        new CustomerService
        //        {
        //            CustomerID = Int32.Parse(userAccountNumber),
        //            PIN = Int32.Parse(userPin),
        //            AccountType = Int32.Parse(userType),
        //            CustomerID = id,

        //        };

        //    AccountService svc = new AccountService();
        //    svc.CreateAccount(accounts);
        //}

        public static void LogIn()
        {
            Console.WriteLine("What is your account number?");
            int accountInput = Int32.Parse(Console.ReadLine());

            Console.WriteLine("What is the pin for your account?");
            int pinInput = Int32.Parse(Console.ReadLine());

            AccountService svc = new AccountService();
            CurrentUserAccount = svc.GetAccountByID(accountInput, pinInput);

        }

       

        public static void Menu()
        {
            Console.WriteLine("Please choose an option from the ones below");
            Console.WriteLine("1.  Make a deposit");
            Console.WriteLine("2.  Make a withdrawal");
            Console.WriteLine("3.  Get account information");
            Console.WriteLine("");
            Console.WriteLine("4.  Log in to your account");
            Console.WriteLine("5.  Create your Account");
            Console.WriteLine("6.  Exit");
        }

        public static void Deposit()
        {
            Console.WriteLine("How much would you like to deposit?");
            int depositAmount = Int32.Parse(Console.ReadLine());
            var svc = new TransactionService();
            CurrentUserAccount = svc.MakeDeposit(CurrentUserAccount, depositAmount);
            Console.WriteLine("Your deposit was successful.");
        }

        public static void Withdrawal()
        {
            Console.WriteLine("How much would you like to withdraw?");
            int withdrawalAmount = Int32.Parse(Console.ReadLine());
            var svc = new TransactionService();
            CurrentUserAccount = svc.MakeWithdrawal(CurrentUserAccount, withdrawalAmount);
            Console.WriteLine("Your withdrawal was successful.");
        }

        
    }
}


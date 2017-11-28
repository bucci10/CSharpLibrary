﻿using Bank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Services
{
    public class AuthService
    {
        public static bool AuthorizeID(int customerID, int pinNumber)
        {
            using (var ctx = new BankDBEntities())
            {
                Customer c =
                    ctx
                        .Customers
                        .FirstOrDefault(e => e.CustomerID == customerID);

                return c.PIN == pinNumber;
            }
        }

        public bool ChangePIN(int customerID, int pinNum, int newPinNum)
        {
            using (var ctx = new BankDBEntities())
            {
                Customer c =
                    ctx
                        .Customers
                        .FirstOrDefault(e => e.CustomerID == customerID);

                if (c.PIN == pinNum)
                {
                    c.PIN = newPinNum;

                    ctx.SaveChanges();

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

    }
}

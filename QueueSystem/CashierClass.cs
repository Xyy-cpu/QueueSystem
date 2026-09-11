using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace QueueSystem
{
    public class CashierClass
    {
        private int x;

        public static string getNumberInQueue = "";
        public static string Serving = "---";
        public static Queue<string> CashierQueue;

        public CashierClass()
        {
            x = 10000;
            CashierQueue = new Queue<string>();
        }

        public string CashierGeneratedNumber(string CashierNumber)
        {
            x++;

            CashierNumber = CashierNumber + x.ToString();

            return CashierNumber;
        }
    }
}
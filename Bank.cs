using System;
using System.Collections.Generic;

namespace ClassyHeist
{
    public class Bank
    {
        public int CashOnHand{get;set;}
        public int AlarmScore{get; set;}
        public int VaultScore{get;set;}
        public int SecurityGuardScore{get;set;}
        public bool IsSecure
        {
            get
            {
                if(CashOnHand + AlarmScore + VaultScore + SecurityGuardScore <= 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        public Bank(int cash, int alarmS, int vaultS, int secGuardS)
        {
            CashOnHand = new Random().Next(50000, 1000001);
            AlarmScore = new Random().Next(0, 101);
            VaultScore = new Random().Next(0, 101);
            SecurityGuardScore = new Random().Next(0, 101);
        }

        public void ReconReport()
        {
            //find the highest stat
            List<int> stats = new List<int>{
                AlarmScore,
                VaultScore,
                SecurityGuardScore
            };
            Console.WriteLine($"The banks most secure system is , it's least secure system is .");
        }
    }

}
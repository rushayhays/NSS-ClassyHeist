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

        public string mostSecure {get;set;}
        public string leastSecure {get;set;}
        public Bank()
        {
            CashOnHand = new Random().Next(50000, 1000001);
            AlarmScore = new Random().Next(0, 101);
            VaultScore = new Random().Next(0, 101);
            SecurityGuardScore = new Random().Next(0, 101);
        }

        public void ReconReport()
        {
            //find the highest stat, and the lowest stat
            if(AlarmScore > VaultScore){
                if(AlarmScore > SecurityGuardScore){
                    mostSecure = "Alarms";
                    if(SecurityGuardScore > VaultScore){
                        leastSecure = "Vaults";
                    }
                    else{
                        leastSecure = "SecurityGuards";
                    }
                }
                else{
                    mostSecure = "SecurityGuards";
                    leastSecure = "Vaults";
                }
            }
            else
            {
                if(VaultScore > SecurityGuardScore){
                    mostSecure = "Vaults";
                    if(SecurityGuardScore>AlarmScore){
                        leastSecure = "Alarms";
                    }else{
                        leastSecure = "SecurityGuards";
                    }
                }
                else{
                    mostSecure = "SecurityGuards";
                    leastSecure = "Alarms";
                }
            }
            Console.WriteLine($"The banks most secure system is {mostSecure} , it's least secure system is {leastSecure}.");
        }
    }

}
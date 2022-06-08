using System;

namespace ClassyHeist
{
    public class Hacker : IRobber
    {
        public string Name{get;set;}
        public int SkillLevel{get;set;}
        public int PercentageCut{get;set;}

       public void PerformSkill(Bank bank)
        {
            bank.AlarmScore = bank.AlarmScore - SkillLevel;
            Console.WriteLine($"Don't worry, {Name} graduated from NSS. Decreased AlarmScore by {SkillLevel} points.");

            if(bank.AlarmScore <= 0 )
            {
                Console.WriteLine($"{Name} succesfully disabled the alarms!");
            }

        }

        public override string ToString()
        {
            return $"Specialty: Hacker ----------- Name:{Name} --- SkillLevel{SkillLevel} --- PercentageCut:{PercentageCut}";
        }
    }
}
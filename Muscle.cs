using System;

namespace ClassyHeist
{
    public class Muscle : IRobber
    {
        public string Name{get;set;}
        public int SkillLevel{get;set;}
        public int PercentageCut{get;set;}

        public void PerformSkill(Bank bank)
        {
            bank.SecurityGuardScore = bank.SecurityGuardScore - SkillLevel;
            Console.WriteLine($"{Name} is getting rough with guards. Decreased SecurityGuardScore by {SkillLevel} points.");

            if(bank.SecurityGuardScore <= 0 )
            {
                Console.WriteLine($"{Name} is walking away from a pile of unconcious guards!");
            }
        }

        public override string ToString()
        {
            return $"Specialty: Muscle ----------- Name:{Name} --- SkillLevel{SkillLevel} --- PercentageCut:{PercentageCut}";
        }
    }
}
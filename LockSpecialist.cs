using System;

namespace ClassyHeist
{
    public class LockSpecialist : IRobber
    {
        public string Name{get;set;}
        public int SkillLevel{get;set;}
        public int PercentageCut{get;set;}

        public void PerformSkill(Bank bank)
        {
            bank.VaultScore = bank.VaultScore - SkillLevel;
            Console.WriteLine($"{Name} is safe cracking. Decreased VaultScore by {SkillLevel} points.");

            if(bank.AlarmScore <= 0 )
            {
                Console.WriteLine($"{Name} popped that safe open in no time!");
            }
        }

        public override string ToString()
        {
            return $"Specialty: LockSpecialist --- Name:{Name} --- SkillLevel{SkillLevel} --- PercentageCut:{PercentageCut}";
        }
    }
}
using System;
using System.Collections.Generic;

namespace ClassyHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Hacker hacker1 = new Hacker
            {
                Name = "Ms. Tarantuala",
                SkillLevel = 85,
                PercentageCut = 15
            };
            Hacker hacker2 = new Hacker
            {
                Name = "Guy in the Chair",
                SkillLevel = 68,
                PercentageCut = 10
            };
            Muscle muscle1 = new Muscle
            {
                Name = "Cobra Bubbles",
                SkillLevel = 75,
                PercentageCut = 30
            };
            Muscle muscle2 = new Muscle
            {
                Name = "Casey Jones",
                SkillLevel = 50,
                PercentageCut = 25
            };
            LockSpecialist lockSpecialist1 = new LockSpecialist
            {
                Name = "The Pink Panther",
                SkillLevel = 87,
                PercentageCut = 25
            };
             LockSpecialist lockSpecialist2 = new LockSpecialist
            {
                Name = "Kaito Kid",
                SkillLevel = 73,
                PercentageCut = 15
            };

            //Here we create our initial list of available 'help'
            List<IRobber> rolodex = new List<IRobber>()
            {
                lockSpecialist1,
                lockSpecialist2,
                muscle1,
                muscle2,
                hacker1,
                hacker2
            };

            /*************************************************************************************/
            /*Main Program starts running down here*/
            Console.WriteLine("Let's make some money");
            Console.WriteLine("");

            Console.WriteLine("Your Under World Contacts:");
            Console.WriteLine("");

            Console.WriteLine($"You currently have {rolodex.Count} contacts in your rolodex");
            Console.WriteLine("");

            string newName = "bobby";
            do
            {
                Console.WriteLine("Enter the name of a new crew member, or press enter to move on:");
                newName = Console.ReadLine();
                if(newName != "")
                {
                    Console.WriteLine("What's thier specialty?");
                    Console.WriteLine(@"
                    1. Hacker (Disables alarms)
                    2. Muscle (Disarms guards)
                    3. Lock Specialist (Cracks vault)
                    ");
                    int specialtyIndex = Int32.Parse(Console.ReadLine());
                    if(specialtyIndex == 1 || specialtyIndex == 2 || specialtyIndex == 3)
                    {
                        Console.WriteLine("Between 1 and 100, what's this person's skill level?");
                        int newSkillLevel = Int32.Parse(Console.ReadLine());

                        if (newSkillLevel >= 0 && newSkillLevel <= 100)
                        {
                            Console.WriteLine("What's thier cut?");
                            int newPercentageCut = Int32.Parse(Console.ReadLine());
                            if(newPercentageCut >=0 && newPercentageCut <= 100)
                            {
                                if(specialtyIndex == 1)
                                {
                                    Hacker goon = new Hacker
                                    {
                                        Name = newName,
                                        SkillLevel = newSkillLevel,
                                        PercentageCut = newPercentageCut
                                    }; 
                                    rolodex.Add(goon);
                                    Console.WriteLine($"{goon.Name} was added to your list of contacts");
                                }
                                else if(specialtyIndex == 2)
                                {
                                    Muscle goon = new Muscle
                                    {
                                        Name = newName,
                                        SkillLevel = newSkillLevel,
                                        PercentageCut = newPercentageCut
                                    }; 
                                    rolodex.Add(goon);
                                    Console.WriteLine($"{goon.Name} was added to your list of contacts");
                                }
                                else if(specialtyIndex == 3)
                                {
                                    LockSpecialist goon = new LockSpecialist
                                    {
                                        Name = newName,
                                        SkillLevel = newSkillLevel,
                                        PercentageCut = newPercentageCut
                                    }; 
                                    rolodex.Add(goon);
                                    Console.WriteLine($"{goon.Name} was added to your list of contacts");
                                }

                                
                            }
                        }
                    }
                }
            }
            while(newName != "");

            ///Now all the crew members have been added, it's time to plan a heist
            Bank bank1 = new Bank();
            bank1.ReconReport();

            //Let's build a crew
            Console.WriteLine("");
            Console.WriteLine("Now that we know what we're dealing with let's build a crew.");
            Console.WriteLine("");

            List<IRobber> crew = new List<IRobber>(){};
            int cutAvailable = 100;
            bool readyForHeist = false;

            while(!readyForHeist)
            {
                for(int x = 0; x < rolodex.Count; x++){
                    if(rolodex[x].PercentageCut < cutAvailable && !crew.Contains(rolodex[x]))
                    {
                        Console.WriteLine(x+1 + ". " + rolodex[x]);
                    }
                }

                Console.WriteLine("Type in the number of the person you want to add or press Enter to run the Heist");
                string stringCrewChoice = Console.ReadLine();
                if(stringCrewChoice != String.Empty){
                    int crewChoice = Int32.Parse(stringCrewChoice)-1;
                    crew.Add(rolodex[crewChoice]);
                    Console.WriteLine($"{rolodex[crewChoice].Name} was added to the crew");
                    Console.WriteLine("----------------------------------------------------------------------------------");
                    Console.WriteLine("");
                }
                else{
                    readyForHeist = true;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Let's rob a bank!");
        }
    }
}

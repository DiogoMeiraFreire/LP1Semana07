using System;

namespace GameUnits
{
    class Program
    {
        private static void Main(string[] args)
        {
            Unit mu = new MilitaryUnit(1, 10, 3);
            Unit su = new SettlerUnit();


            MilitaryUnit attackUnit = mu as MilitaryUnit;


            attackUnit.Move();
            su.Move();


            Console.WriteLine($"Military unit's health {attackUnit.Health}");

            Console.WriteLine($"Settler unit's health {su.Health}");


            Console.WriteLine($"Cost of Military unit {attackUnit.Cost}");
            Console.WriteLine($"Cost of Settler unit {su.Cost}");


            attackUnit.Attack(su); 
            Console.WriteLine($"Settler unit's health after: {su.Health}");

            Unit[] units = new Unit[]
            {
                new MilitaryUnit(3, 10, 2),
                new MilitaryUnit(4, 5, 3),
                new SettlerUnit(),
            };

            (units[0] as MilitaryUnit).Attack(units[1]);
            (units[0] as MilitaryUnit).Attack(units[2]);

            foreach (Unit u in units)
            {
                Console.WriteLine(u.ToString());
            }
        }
    }
}

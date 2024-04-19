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


            Console.WriteLine($"Military health {attackUnit.Health}");

            Console.WriteLine($"Settler Health {su.Health}");


            Console.WriteLine($"Cost of Military {attackUnit.Cost}");
            Console.WriteLine($"Cost of Settler {su.Cost}");


            attackUnit.Attack(su); 
            Console.WriteLine($"Settler Health after: {su.Health}");

           
        }
    }
}

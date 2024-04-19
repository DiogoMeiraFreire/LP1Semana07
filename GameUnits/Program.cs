using System;

namespace GameUnits
{
    class Program
    {
        private static void Main(string[] args)
        {
            // EX 5
  
            // ------  instantiate objects ------ //

            // instance of Units
            // MilitaryUnit & SettlerUnit inherit from Unit
            Unit mu = new MilitaryUnit(1, 10, 3);
            Unit su = new SettlerUnit();


            // declaration for non abstract methods
            // requires casting type
            MilitaryUnit attackUnit = mu as MilitaryUnit;
            //SettlerUnit settlerUnit = su as SettlerUnit;


            // ---------- Move units -------------- //
            attackUnit.Move();
            su.Move();

            // -------- Display Health ------------ //

            // health of military unit
            Console.WriteLine($"Military health {attackUnit.Health}");

            // health of settler unit
            Console.WriteLine($"Settler Health {su.Health}");


            // -------- Display Cost ------------ //
            Console.WriteLine($"Cost of Military {attackUnit.Cost}");
            Console.WriteLine($"Cost of Settler {su.Cost}");


            // -------- Attack unit -------- //
            attackUnit.Attack(su); 
            // health of settler unit
            Console.WriteLine($"Settler Health after: {su.Health}");
      
            // EX 6 


            // Criar array com três unidades
            Unit[] units = new Unit[]
            {
                new MilitaryUnit(3, 10, 2),
                new MilitaryUnit(4, 5, 3),
                new SettlerUnit(),
            };

            // Unidade 0 ataca unidade 1
            (units[0] as MilitaryUnit).Attack(units[1]);
            // Unidade 0 ataca unidade 2
            (units[0] as MilitaryUnit).Attack(units[2]);

            // "Imprimir" cada unidade
            // chamando implicitamente o método ToString() de cada uma delas
            foreach (Unit u in units)
            {
                Console.WriteLine(u.ToString());
            }

            // Output esperado:
            //
            // MilitaryUnit: HP=12 COST=4 AP=2 XP=2
            // MilitaryUnit: HP=3 COST=3 AP=3 XP=0
            // SettlerUnit: HP=1 COST=5





        }
    }
}

using System;

namespace GameUnits
{
    public class Program
    {
        private static void Main()
        {
            // Criar array com três unidades
            Unit[] units = new Unit[]
            {
                new MilitaryUnit(3, 10, 2),
                new MilitaryUnit(4, 5, 3),
                new SettlerUnit(),
                new SpyUnit(),
                new SpyUnit()
            };

            // Unidade 0 ataca unidade 4
            (units[0] as MilitaryUnit).Attack(units[4]);
            // Unidade 0 ataca unidade 2
            (units[0] as MilitaryUnit).Attack(units[2]);
            // Unidade 3 espia unidade 4
            (units[3] as SpyUnit).GetSecretInfo(units[4]);
            // Unidade 4 espia unidade 2
            (units[4] as SpyUnit).GetSecretInfo(units[2]);

            // "Imprimir" cada unidade
            // chamando implicitamente o método ToString() de cada uma delas
            foreach (Unit u in units)
            {
                Console.WriteLine(u);
            }

            // Output esperado:
            //
            // MilitaryUnit: HP=12 COST=4.00 XP=2 AP=2
            // MilitaryUnit: HP=5 COST=3.00 XP=0 AP=3
            // SettlerUnit: HP=1 COST=5.00
            // SpyUnit: HP=2 COST=12.50 XP=3
            // SpyUnit: HP=0 COST=12.50 XP=1
        }
    }
}

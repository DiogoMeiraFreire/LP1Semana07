using System;

namespace GameUnits
{
    public class MilitaryUnit : XPUnit
    {

        private int movement; 

        public int AttackPower {get; }

        public override int Health 
        { 
            get => base.Health;
            set => base.Health = value + XP; 
        }


        public override float Cost 
        {
            get => AttackPower + XP;
        }


        public MilitaryUnit(
            int mov, int health, int attackPower) : base(mov, health)
        {                          
            AttackPower = attackPower;

            movement    = mov;
        }


        //
        public override void Move()
        {
            movement++;

            Console.WriteLine(movement);
        }

        public void Attack(Unit u)
        {
            XP += 1;

            u.Health -= AttackPower;
        }

        public override string ToString()
        {
            return base.ToString() + $" AP={AttackPower}";

        }


        
    }
}

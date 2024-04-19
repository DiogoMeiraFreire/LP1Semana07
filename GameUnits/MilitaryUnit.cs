using System;

namespace GameUnits
{
    public sealed class MilitaryUnit : Unit // Heranca!!
    {

        private int movement; 

        public int AttackPower {get; }


        // can only be set in the constructor or class itself
        public int XP {get; private set; }


        // override Health property
        public override int Health 
        { 
            get => base.Health;         // added XP value
            set => base.Health = value + XP; 
        }


        // override Cost property
        public override float Cost 
        {
            get => AttackPower + XP;
        }


        // CLASS CONSTRUCTOR

        /// <summary>
        /// Constructor for MilitaryUnit.
        /// Inherits from Unit & passes movement(mov) & health to the base class.
        /// 
        /// </summary>
        /// <param name="mov">value of movement</param>
        /// <param name="health">value of character health</param>
        /// <param name="attackPower">value of damage</param>
        public MilitaryUnit(
            int mov, int health, int attackPower) : base(mov, health)
        { //                                          Unit(int, int)                          
            

            XP          = 0;                                           
            AttackPower = attackPower;

            // added movement
            movement    = mov;

            
        }


        //
        public override void Move()
        {
            movement++;

            Console.WriteLine(movement);
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="u"></param>
        public void Attack(Unit u)
        {
            // increment XP  
            XP += 1;

            // unit health is reduced by the attack power of this unit
            u.Health -= AttackPower;
        }

        // EX 6

        public override string ToString()
        {
            return base.ToString() + $" AP={AttackPower} XP={XP}";

        }


        
    }
}

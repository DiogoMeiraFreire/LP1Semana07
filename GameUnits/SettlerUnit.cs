

using System;
using System.Runtime.CompilerServices;

namespace GameUnits
{
    public sealed class SettlerUnit : Unit
    {
        // 
        private int movement;

        // override the Health property in Unit
        public override int Health 
        {
            get => base.Health;  
            set => base.Health = value; 
             
        }

        // override the Cost property in Unit, returns 5
        public override float Cost { get => 5; }

        /// <summary>
        /// Constructor for SettlerUnit
        /// Inherits from Unit & passes health to the base class
        /// </summary>
        /// <param name="health"></param>
        /// <returns></returns>
        public SettlerUnit(int mov = 1, int health = 3) : base(mov ,health)
        {
            movement = mov;
            Health = health;
        }

        public override void Move()
        {
            movement++; 

            Console.WriteLine(movement);
        
        }


        public override string ToString()
        {
            return base.ToString();
        }
    }
}

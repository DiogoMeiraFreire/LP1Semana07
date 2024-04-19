

using System;
using System.Runtime.CompilerServices;

namespace GameUnits
{
    public sealed class SettlerUnit : Unit
    {
        private int movement;

        public override int Health 
        {
            get => base.Health;  
            set => base.Health = value; 
             
        }

        public override float Cost { get => 5; }

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

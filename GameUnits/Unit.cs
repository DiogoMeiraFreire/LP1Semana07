namespace GameUnits
{
    public abstract class Unit
    {
        private int movement;

        // changed to virtual => is overridable
        public virtual int Health { get; set; }

        // 
        public abstract float Cost { get; }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="movement"></param>
        /// <param name="health"></param>
        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        // ex 6
        public override string ToString()
        {
            return $"{GetType().Name}: HP={Health} Cost={Cost:F2}";
        }


        public abstract void Move();

    }
}

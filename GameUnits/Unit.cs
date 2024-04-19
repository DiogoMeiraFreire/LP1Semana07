namespace GameUnits
{
    public abstract class Unit
    {
        private int movement;

        public virtual int Health { get; set; }

        public abstract float Cost { get; }

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        public override string ToString()
        {
            return $"{GetType().Name}: HP={Health} Cost={Cost:F2}";
        }

        public abstract void Move();
    }
}

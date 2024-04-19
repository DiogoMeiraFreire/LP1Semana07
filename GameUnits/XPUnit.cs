namespace GameUnits
{
    public abstract class XPUnit : Unit
    {
        public int XP { get; protected set;}

        public override float Cost {get;} 


        public XPUnit(int mov, int health) : base(mov, health)
        {
            XP = 0;
        }

        // Override ToString
        public override string ToString()
        {
            return base.ToString() + $" XP={XP}";
        }



    }
}
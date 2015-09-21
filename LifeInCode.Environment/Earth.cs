namespace LifeInCode.Environment
{
    public class Earth
    {
        private const decimal Gravity = 9.807m;

        public decimal GetGravity { get { return Gravity; }  }


        public static decimal WeightInNewtons(decimal mass)
        {
            return mass*Gravity;
        }
    }
}

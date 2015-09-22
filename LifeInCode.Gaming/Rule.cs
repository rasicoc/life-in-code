namespace LifeInCode.Gaming
{
    public class Rule
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Priority Priority { get; set; }
        public int Order { get; set; }
    }

    public enum Priority
    {
        High,
        Low,
        Optional
    }
}

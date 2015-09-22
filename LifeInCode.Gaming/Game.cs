using System.Collections.Generic;

namespace LifeInCode.Gaming
{
    public class Game
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<Rule> Rules { get; set; } 

    }
}

using OpenClose.Interfaces;

namespace OpenClose.Pizza
{
    public class TunaPizza : IPizza
    {
        public string Name => "Shrimp and tuna Pizza";

        public double Price => 65;

        public double Calories => 231;
    }
}

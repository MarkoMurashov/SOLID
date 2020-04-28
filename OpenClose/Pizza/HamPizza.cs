using OpenClose.Interfaces;

namespace OpenClose.Pizza
{
    public class HamPizza : IPizza
    {
        public string Name => "Ham Pizza";

        public double Price => 55;

        public double Calories => 260;
    }
}

using OpenClose.Interfaces;

namespace OpenClose.Pizza
{
    public class KebabPizza : IPizza
    {
        public string Name => "Kebab pizza";

        public double Price => 60;

        public double Calories => 255;
    }
}

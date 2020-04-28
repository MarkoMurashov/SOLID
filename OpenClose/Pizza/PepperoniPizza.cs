using OpenClose.Interfaces;

namespace OpenClose.Pizza
{
    public class PepperoniPizza : IPizza
    {
        public string Name => "Pepperoni Pizza"; 

        public double Price => 45;

        public double Calories => 253;

    }
}

using OpenClose.Decorator;
using OpenClose.Interfaces;

namespace OpenClose.Extra
{
    public class PepperExtra : ExtrasDecorator
    {
        public override string Name => Pizza.Name + ", Extra Pepperoni"; 

        public override double Price => Pizza.Price + 8; 

        public override double Calories=> Pizza.Calories + 25; 

        public PepperExtra(IPizza pizza) : base(pizza) { }
    }
}

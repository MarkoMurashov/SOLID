using OpenClose.Decorator;
using OpenClose.Interfaces;

namespace OpenClose.Extra
{
    public class CheeseExtra : ExtrasDecorator
    {
        public override string Name => Pizza.Name + ", Extra Ost"; 

        public override double Price => Pizza.Price + 6; 

        public override double Calories => Pizza.Calories + 40; 

        public CheeseExtra(IPizza pizza) : base(pizza) { }
    }
}

using OpenClose.Decorator;
using OpenClose.Interfaces;

namespace OpenClose.Extra
{
    public class FamilySize : ExtrasDecorator
    {
        public override string Name => "Familie " + Pizza.Name; 

        public override double Price => Pizza.Price * 1.5; 

        public override double Calories => Pizza.Calories * 1.5; 

        public FamilySize(IPizza pizza) : base(pizza) { }
    }
}

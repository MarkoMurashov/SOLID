using OpenClose.Interfaces;

namespace OpenClose.Decorator
{
    public abstract class ExtrasDecorator : IPizza
    {
        protected IPizza Pizza;

        public abstract string Name { get; }

        public virtual double Price => Pizza.Price;

        public virtual double Calories => Pizza.Calories;


        public ExtrasDecorator(IPizza pizza)
        {
            Pizza = pizza;
        }
    }
}

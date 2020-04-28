using OpenClose.Enums;
using OpenClose.Extra;
using OpenClose.Interfaces;
using OpenClose.Pizza;
using System.Collections.Generic;

namespace OpenClose.Factory
{
    public class OrdinaryPizzaFactory: IPizzaFactory
    {
        public IPizza MakePizza(List<Extras> extras, PizzaType type)
        {
            IPizza pizza = CreatePizza(type);

            foreach (Extras extra in extras)
            {
                pizza = AddExtras(extra, pizza);
            }

            return pizza;
        }


        private IPizza CreatePizza(PizzaType type)
        {

            switch (type)
            {
                case PizzaType.Pepperoni:
                    return new PepperoniPizza();

                case PizzaType.Tuna:
                    return new TunaPizza();

                case PizzaType.Ham:
                    return new HamPizza();

                case PizzaType.Kebab:
                    return new KebabPizza();

                default:
                    return null;
            }

        }

        private IPizza AddExtras(Extras type, IPizza pizza)
        {
            if (type == Extras.Pepper)
            {
                return new PepperExtra(pizza);
            }
            else if (type == Extras.Cheese)
            {
                return new CheeseExtra(pizza);
            }
            else if (type == Extras.Family)
            {
                return new FamilySize(pizza);
            }
            else
            {
                return null;
            }
        }
    }
}

using OpenClose.Enums;
using System.Collections.Generic;

namespace OpenClose.Interfaces
{
    public interface IPizzaFactory
    {
        IPizza MakePizza(List<Extras> ekstrasList, PizzaType type);
    }
}

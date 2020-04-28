using SingleResponsibility.Enums;
using SingleResponsibility.Models;

namespace SingleResponsibility
{
    public abstract class HouseBuilder
    {
        public House House { get; private set; }

        public HouseBuilder(string name, int rooms, Styles styles)
        {
            House = new House(name, rooms, styles);
        }

        public abstract void BuildWalls();
        public abstract void BuildBathroom();
        public abstract void BuildKitchen();

    }
}

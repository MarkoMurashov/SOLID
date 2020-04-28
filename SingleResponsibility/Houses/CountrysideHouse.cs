using SingleResponsibility.Enums;

namespace SingleResponsibility.Houses
{
    public class CountrysideHouse : HouseBuilder
    {
        public CountrysideHouse(string name, int rooms, Styles styles)
            : base(name, rooms, styles)
        {

        }

        public override void BuildBathroom()
        {
            House.Bathroom = RoomSize.Small;
        }

        public override void BuildKitchen()
        {
            House.Kitchen = RoomSize.Small;
        }

        public override void BuildWalls()
        {
            House.Wall = Materials.Wood;
        }
    }
}

using SingleResponsibility.Enums;

namespace SingleResponsibility.Houses
{
    public class OceansideHouse: HouseBuilder
    {
        public OceansideHouse(string name, int rooms, Styles styles)
            : base(name, rooms, styles)
        {

        }

        public override void BuildBathroom()
        {
            House.Bathroom = RoomSize.Small;
        }

        public override void BuildKitchen()
        {
            House.Kitchen = RoomSize.Middle;
        }

        public override void BuildWalls()
        {
            House.Wall = Materials.Bricks;
        }
    }
}

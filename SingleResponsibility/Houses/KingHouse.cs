using SingleResponsibility.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibility.Houses
{
    public class KingHouse : HouseBuilder
    {
        public KingHouse(string name, int rooms, Styles styles)
            :base(name,rooms,styles)
        {

        }

        public override void BuildBathroom()
        {
            House.Bathroom = Enums.RoomSize.Big;
        }

        public override void BuildKitchen()
        {
            House.Kitchen = Enums.RoomSize.Big;
        }

        public override void BuildWalls()
        {
            House.Wall = Enums.Materials.Bricks;
        }
    }
}

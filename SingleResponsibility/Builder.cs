using System;
using System.Collections.Generic;
using System.Text;
using SingleResponsibility.Models;

namespace SingleResponsibility
{
    public class Builder
    {
        public House Construct(HouseBuilder houseBuilder)
        {
            houseBuilder.BuildWalls();
            houseBuilder.BuildKitchen();
            houseBuilder.BuildBathroom();

            return houseBuilder.House;
        }
    }
}

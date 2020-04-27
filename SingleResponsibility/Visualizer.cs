using SingleResponsibility.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibility
{
    public class Visualizer
    {
        public static string Visualize(House house)
        {
            string info = string.Empty;

            info += "Your house name: " + house.Name;
            info += "\nRooms quantity: " + house.Rooms;
            info += "\nWalls are made of " + house.Wall.ToString().ToLower();
            info += "\nThe kitchen is " + house.Kitchen.ToString().ToLower();
            info += " and the bathroom is " + house.Bathroom.ToString().ToLower();
            info += "\nThe house is made in a " + house.Style.ToString().ToLower() + " style";

            return info;
        }
    }
}

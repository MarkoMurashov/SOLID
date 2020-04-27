using System;
using System.Collections.Generic;
using System.Text;
using SingleResponsibility.Enums;

namespace SingleResponsibility.Models
{
    public class House
    {
        public string Name { get; set; }

        public int Rooms { get; set; }

        public Styles Style { get; set; }

        public Materials Wall { get; set; }

        public RoomSize Kitchen { get; set; }

        public RoomSize Bathroom { get; set; }

        public House(string name, int rooms, Styles styles)
        {
            Name = name;
            Rooms = rooms;
            Style = styles;
        }
    }
}

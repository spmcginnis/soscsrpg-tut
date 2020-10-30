﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class World
    {
        private List<Location> _locations = new List<Location>();

        internal void AddLocation(int x, int y, string name, string desc, string src)
        {
            Location loc = new Location();
            loc.XCoordinate = x;
            loc.YCoordinate = y;
            loc.Name = name;
            loc.Desc = desc;
            loc.ImgSrc = src;

            _locations.Add(loc);
        }

        public Location LocationAt(int x, int y)
        {
            foreach(Location loc in _locations)
            {
                if(loc.XCoordinate == x && loc.YCoordinate == y)
                { return loc; }
            }

            return null;
        }

    }
}

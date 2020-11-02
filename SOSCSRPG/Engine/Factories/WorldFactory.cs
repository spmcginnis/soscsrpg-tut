using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal static class WorldFactory
    {
        internal static World CreateWorld()
        {
            World newWorld = new World();
            newWorld.AddLocation(0,-1,"Home",
                "This is a house.  Your house.",
                "/Engine;component/Images/Locations/Home.jpg");

            newWorld.AddLocation(-1, -1, "Farm House",
                "This is your neighbor's farm.",
                "");

            newWorld.AddLocation(-2, -1, "Wheat Field",
                "The wheat here is plentiful.  So are the rats.",
                "");

            return newWorld;
        }
    }
}

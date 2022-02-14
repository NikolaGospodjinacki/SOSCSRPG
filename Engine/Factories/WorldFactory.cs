using System;
using System.Collections.Generic;
using System.Text;
using Engine.Models;
namespace Engine.Factories
{
    internal class WorldFactory
    {
      internal World CreateWorld()
        {
            World newWorld = new World();

            newWorld.AddLocation(-2, -1, "Farmer's Field",
                "Endless fields of corn, infested with sneaky rats.",
                "/Engine;component/Images/Locations/FarmFields.png");

            newWorld.AddLocation(-1, -1, "Farmer's House",
                "Farmer Tod lives here. A decent fella, helped you with your harvest once.",
                "/Engine;component/Images/Locations/Farmhouse.png");

            newWorld.AddLocation(0, -1, "Home",
                "This is where you reside. Nothing flashy, but comfy.",
                "/Engine;component/Images/Locations/Home.png");

            newWorld.AddLocation(-1, 0, "Trading Shop",
                "Trader Grindalot lives here. Always working.",
                "/Engine;component/Images/Locations/Trader.png");

            newWorld.AddLocation(0, 0, "Town square",
                "Fairly large fountain in the middle. The usual.",
                "/Engine;component/Images/Locations/TownSquare.png");

            newWorld.AddLocation(1, 0, "Town Gate",
                "There is a gate here, protecting the town from goblins and orcs.",
                "/Engine;component/Images/Locations/TownGate.png");

            newWorld.AddLocation(2, 0, "Spooder forest",
                "Ancient trees, almost snow white due to all the webs.",
                "/Engine;component/Images/Locations/SpiderForest.png");

            newWorld.AddLocation(0, 1, "Herbalist's hut",
                "A small hut, a large improvised drying rack next to it..",
                "/Engine;component/Images/Locations/HerbalistsHut.png");

            newWorld.AddLocation(0, 2, "Herbalist's garden",
                "Full of colorful plants, be careful about the sneaks tho'.",
                "/Engine;component/Images/Locations/HerbalistsGarden.png");

            return newWorld;
        }
    }
}

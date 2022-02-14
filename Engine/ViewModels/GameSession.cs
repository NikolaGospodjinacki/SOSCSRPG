using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Factories;
using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }
        public World CurrentWorld { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player
            {
                Name = "Nikola",
                Class = "Mage",
                HitPoints = 20,
                ExperiencePoints = 0,
                Level = 1,
                Gold = 1000
            };
            CurrentLocation = new Location()
            {
                Name = "Home",
                XCoordinate = 0,
                YCoordinate = -1,
                Description = "This is your primary residence",
                ImageName = "/Engine;component/Images/Locations/Home.png"

            };

            WorldFactory factory = new WorldFactory();
            CurrentWorld = factory.CreateWorld();

            CurrentLocation = CurrentWorld.LocationAt(0, 0);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }

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

        }
    }
}

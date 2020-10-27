using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.ViewModels
{
    class GameSession
    {
        PlayerCharacter CurrentPlayer { get; set; }

        public GameSession()
        {
            CurrentPlayer = new PlayerCharacter();
            CurrentPlayer.Name = "Scott";
            CurrentPlayer.Gold = 1000000;


        }
    }
}

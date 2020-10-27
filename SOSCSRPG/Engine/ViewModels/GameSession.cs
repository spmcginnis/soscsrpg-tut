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
        public PlayerCharacter CurrentPlayer { get; set; }

        public GameSession()
        {
            CurrentPlayer = new PlayerCharacter();
            CurrentPlayer.Name = "Scott";
            CurrentPlayer.Gold = 1000000;
            CurrentPlayer.CharacterClass = "Fighter";
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.CharacterLevel = 1;



        }
    }
}

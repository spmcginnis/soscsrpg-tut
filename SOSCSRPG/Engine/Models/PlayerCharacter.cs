using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    class PlayerCharacter
    {
        string Name { get; set; }
        string CharacterClass { get; set; }
        int HitPoints { get; set; }
        int ExperiencePoints { get; set; }
        int CharacterLevel { get; set; }
        int Gold { get; set; }
    }
}

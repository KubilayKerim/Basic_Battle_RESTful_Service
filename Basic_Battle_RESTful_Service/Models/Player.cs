using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic_Battle_RESTful_Service.Models
{
    public class Player
    {
        public int Id { get; set; }
        public bool SelectedCharacter { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public int Armour { get; set; }
        public int HealthRate { get; set; }
        public int ArmorRate { get; set; }
        public int Damage { get; set; }
        public string SpecialAttackName { get; set; }
        public int SpecialAttackDamage { get; set; }
        public string SpecialAttackName1 { get; set; }
        public int SpecialAttackDamage1 { get; set; }
    }
}

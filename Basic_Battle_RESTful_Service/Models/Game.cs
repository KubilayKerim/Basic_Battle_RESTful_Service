using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic_Battle_RESTful_Service.Models
{
    public class Game
    {
        public int Id { get; set; }
        public int TurnCounter { get; set; }
        public int WhichPlayer { get; set; }
        public int MatchLogID { get; set; }
        public int RedID { get; set; }
        public int BlueID { get; set; }
        public int WinnerID { get; set; }
    }
}

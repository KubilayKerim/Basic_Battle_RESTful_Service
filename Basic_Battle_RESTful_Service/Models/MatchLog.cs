using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic_Battle_RESTful_Service.Models
{
    public class MatchLog
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int GameID { get; set; }
    }
}
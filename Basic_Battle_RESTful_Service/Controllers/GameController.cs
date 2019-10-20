using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Basic_Battle_RESTful_Service.Models;


namespace Basic_Battle_RESTful_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly DataBaseContext _context;
        public GameController(DataBaseContext context)
        {
            _context = context;
        }

        // GET: api/Game
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Game.ToList());
        }

        // GET: api/Game/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            return Ok(_context.Game.FirstOrDefault(x=>x.Id == id));
        }

        // POST: api/Game
        [HttpPost]
        public void Post([FromBody] Game game)
        {
            //return Ok(_context.Game.FirstOrDefault(x => x.Id == id));
        }

        //api/Game/Hit
        [HttpPost]
        //public object Hit(int gameID, int playerID, int enemyID, int skills)
        //{
        //    var game = _context.Game.FirstOrDefault(x => x.Id == gameID);
        //    var player = _context.Player.FirstOrDefault(x => x.Id == playerID);
        //    //HESAPLAMALAR YAPILACAK
        //    var enemy = _context.Player.FirstOrDefault(x => x.Id == enemyID);

        //    for (int i = 0; i < int.MaxValue; i++)
        //    {
        //        game.TurnCounter = i;
        //        if (game.TurnCounter == 0)
        //        {
        //            player.Health = player.HealthRate;
        //            player.Armour = player.ArmorRate;
        //            enemy.Health = enemy.HealthRate;
        //            enemy.Armour = enemy.ArmorRate;
        //        }
        //        if (game.TurnCounter % 2 == 0)
        //        {
        //            if (enemy.Health == 0)
        //            {
        //                //game over
        //                return Ok("{game over}");
        //            }
        //            switch (skills)//player attack choice
        //            {
        //                case 1:
        //                    enemy.Health -= player.Damage + enemy.Armour / 2;
        //                    break;
        //                case 2:
        //                    enemy.Health -= player.SpecialAttackDamage + enemy.Armour / 4;
        //                    break;
        //                case 3:
        //                    enemy.Health -= player.SpecialAttackDamage1 + enemy.Armour / 4;
        //                    break;
        //            }
        //        }
        //        else
        //        {
        //            if (player.Health == 0)
        //            {
        //                //game over
        //                return Ok("{game over}");
        //            }
        //            Random rnd = new Random();
        //            int dice = rnd.Next(1, 3);
        //            switch (dice)
        //            {
        //                case 1:
        //                    player.Health -= enemy.Damage + player.Armour / 2;
        //                    break;
        //                case 2:
        //                    player.Health -= enemy.SpecialAttackDamage + player.Armour / 4;
        //                    break;
        //                case 3:
        //                    player.Health -= enemy.SpecialAttackDamage1 + player.Armour / 4;
        //                    break;
        //            }
        //        }
        //        return Ok("{}");
        //    }
        //}

        // PUT: api/Game/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Game game = _context.Game.Single(x => x.Id == id);
            _context.Game.Remove(game);
            _context.SaveChanges();
        }
    }
}
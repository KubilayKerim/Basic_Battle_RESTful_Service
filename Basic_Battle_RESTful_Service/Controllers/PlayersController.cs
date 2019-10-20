using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Basic_Battle_RESTful_Service.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basic_Battle_RESTful_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : Controller
    {
        private readonly DataBaseContext _context;
        public PlayerController(DataBaseContext context)
        {
            _context = context;
        }
                
        [HttpGet]
        public JsonResult Get()
        {
            
            return Json(_context.Player.ToList());
        }

       
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            
            Player player = _context.Player.Single(p => p.Id == id);
            return Json(player);
        }

        // POST api/Player
        [HttpPost]
        public JsonResult Post([FromBody] Player newPlayer)
        {
            
            _context.Player.Add(newPlayer);
            _context.SaveChanges();
            
            return Json(_context.Player);
        }

        //PUT api/Player/5
        [HttpPut("{id}")]
        public JsonResult Put(int id, [FromBody] bool newSelected_Character)
        {
            Player player = _context.Player.Single(p => p.Id == id);
            player.SelectedCharacter = newSelected_Character;
            _context.SaveChanges(player.SelectedCharacter);
            return Json(player.SelectedCharacter);
        }

        // PUT game
        [HttpPut]
        public JsonResult Put(int id, int _id)
        {
            Player player = _context.Player.Single(p => p.Id == id);
            Player enemy = _context.Player.Single(p => p.Id == _id);
            return Json(Game(id, _id));
        }

        // PUT attackchoice
        [HttpPut("{attackchoice}")]
        public int Put(int _attackchoice)
        {
            attackchoice = _attackchoice;
            return (attackchoice);
        }

        // DELETE api/Player/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Player player = _context.Player.Single(p => p.Id == id);
            _context.Player.Remove(player);
            _context.SaveChanges();
        }

        //db ile bağlantı kur objenin instanceını oluştur instance ı döngüye sok

        public int attackchoice;
        public JsonResult Game(int id, int enemyid)
        {
            Player player = _context.Player.Single(p => p.Id == id);
            Player enemy = _context.Player.Single(p => p.Id == enemyid);

            if (player.SelectedCharacter == true)
            {

                for (int turn = 0; turn < Int32.MaxValue; turn++)
                {
                    if (turn % 2 == 0)
                    {
                        if (player.Health == 0)
                        {
                            //game over
                            return Json("{game over}");
                        }
                        switch (attackchoice)//player attack choice
                        {
                            case 1:
                                enemy.Health -= player.Damage + enemy.Armour / 2;
                                break;
                            case 2:
                                enemy.Health -= player.SpecialAttackDamage + enemy.Armour / 4;
                                break;
                            case 3:
                                enemy.Health -= player.SpecialAttackDamage1 + enemy.Armour / 4;
                                break;
                        }
                    }
                    else
                    {
                        if (enemy.Health == 0)
                        {
                            //game over
                            return Json("{game over}");
                        }
                        Random rnd = new Random();
                        int dice = rnd.Next(1, 3);
                        switch (dice)
                        {
                            case 1:
                                player.Health -= enemy.Damage + player.Armour / 2;
                                break;
                            case 2:
                                player.Health -= enemy.SpecialAttackDamage + player.Armour / 4;
                                break;
                            case 3:
                                player.Health -= enemy.SpecialAttackDamage1 + player.Armour / 4;
                                break;
                        }
                    }
                }

            }
            return Json("");
        }
    }
}

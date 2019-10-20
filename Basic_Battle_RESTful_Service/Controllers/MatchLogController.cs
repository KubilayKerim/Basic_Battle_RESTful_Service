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
    public class MatchLogController : ControllerBase
    {
        private readonly DataBaseContext _context;
        public MatchLogController(DataBaseContext context)
        {
            _context = context;
        }

        // GET: api/MatchLog
        [HttpGet]
        public IActionResult Get()
        {            
            return Ok(_context.MatchLog.ToList());
        }

        // GET: api/MatchLog/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            return Ok(_context.MatchLog.FirstOrDefault(p => p.Id == id));
        }

        // POST: api/MatchLog
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/MatchLog/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            MatchLog matchLog = _context.MatchLog.Single(p => p.Id == id);
            _context.MatchLog.Remove(matchLog);
            _context.SaveChanges();
        }
    }
}

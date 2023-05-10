using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using swaggerapi.Data;
using swaggerapi.Models;

namespace swaggerapi.Controllers
{
    [Route("api/demo")]
    [ApiController]
    public class TrainController : Controller
    {
        private readonly TrainContext _context;
        public TrainController(TrainContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("getlist")]
        public async Task<IActionResult> Get()
        {
            var users = await _context.trains.ToListAsync();
            return Ok(users);
        }

        [HttpGet]
        [Route("getbyid/{id}")]
        public async Task<IActionResult> Getbyid(int id)
        {
            var user = _context.trains.Where(t => t.trainId == id).FirstOrDefault();
            if (user == null)
            {
                return BadRequest("Train Not Found");
            }
            return Ok(user);
        }


        [HttpPost]
        [Route("add-train")]
        public async Task<IActionResult> POST(Train t)
        {
            _context.trains.Add(t);
            await _context.SaveChangesAsync();
            return Ok(t);
        }

        [HttpDelete]
        [Route("deleteTrain/{id}")]
        public async Task<IActionResult> deleteTrain(int id)
        {
            var obj = _context.trains.Where(tr=>tr.trainId== id).FirstOrDefault();
            _context.trains.Remove(obj);
            await _context.SaveChangesAsync();
            return Ok(obj);
        }

        [HttpPut]
        [Route("update/{id}")]
        public async Task<IActionResult> updateTrain(int id,[FromBody] Train t)
        {
            var obj = _context.trains.Where(tr=>tr.trainId== id).FirstOrDefault();
            if(obj == null)
            {
                return BadRequest("Not Found");
            }
            obj.trainName = t.trainName;
            obj.from = t.from;
            obj.to = t.to;
            await _context.SaveChangesAsync();
            return Ok(t);
        }


    }
}

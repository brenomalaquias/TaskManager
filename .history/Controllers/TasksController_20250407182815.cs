using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Data;

namespace TaskManager.Controllers
{
   [ApiController]
   [Route]
    public class TasksController : ControllerBase
    {
        private readonly AppDbContext _context;   

        public TasksController(AppDbContext context)
        {
            _context = context;
        } 

        [HttpGet]
        public IActionResult GetAll()
        {
            var tasks = _context.Tasks.ToList();

            return Ok(tasks);
        }

        [HttpGet("id")]
        public IActionResult GetById([FromRoute] int id)
        {
            var tasks = _context.Tasks.Find(id);

            if(tasks == null)
            {
                return NotFound();
            }

            return Ok(tasks);
        }
    }
}
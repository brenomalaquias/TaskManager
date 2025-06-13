using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Data;
using TaskManager.Mappers;

namespace TaskManager.Controllers
{
   [ApiController]
   [Route("api/controller")]
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
            var tasks = _context.Tasks.ToList()
            .Select( t => t.ToTasksDto());

            return Ok(tasks);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var tasks = _context.Tasks.Find(id);

            if(tasks == null)
            {
                return NotFound();
            }

            return Ok(tasks.ToTasksDto());
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateTasksRequest tasksDto)
        {
            var tasksModel = taskDto.ToTasksFromCreateDto();
             
        }
        
    }
}
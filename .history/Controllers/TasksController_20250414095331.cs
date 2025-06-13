using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Data;
using TaskManager.Dtos.Users.Tasks;
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
        public IActionResult Create([FromBody] CreateTasksRequestsDto tasksDto)
        {
            var tasksModel = tasksDto.ToTasksFromCreateDto();
            _context.Tasks.Add(tasksModel); 
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new{ id = tasksModel.Id },tasksModel.ToTasksDto());
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] UpdateTasksDto updateDto)
        {
            var tasksModel = _context.Tasks.FirstOrDefault(x => x.Id == id);

            if(tasksModel == null)
            {
                return NotFound();
            }

            tasksModel.Name = updateDto.Name;

            _context.SaveChanges();

            return Ok(tasksModel.ToTasksDto());
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var tasksModel = _context.Tasks.FirstOrDefault(x => x.Id == id);

            if( tasksModel == null)
            {
                return NotFound();
            }

            _context.Tasks.Remove(tasksModel);

            _context.SaveChanges();
        }
        
    }
}
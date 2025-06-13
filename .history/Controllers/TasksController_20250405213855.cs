using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Data;

namespace TaskManager.Controllers
{
   
    public class TasksController : ControllerBase
    {
        private readonly AppDbContext _context;   

        public TasksController(AppDbContext context)
        {
            _context = context;
        } 

        [HttpGet]
            
    }
}
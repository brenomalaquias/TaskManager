using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TaskManager.Controllers
{
    [Route("api/tasks")]
    [ApiController]
    private readonly AppDbContext _context;
    public class TasksController : ControllerBase
    {
        
    }
}
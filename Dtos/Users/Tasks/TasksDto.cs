using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Dtos.Users.Tasks
{
    public class TasksDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool IsDone { get; set; } 
        
    }
}
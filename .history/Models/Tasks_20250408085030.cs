using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    public class Tasks
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int UsersId { get; set; }
        public Users? Users { get; set;}
        

    }
}
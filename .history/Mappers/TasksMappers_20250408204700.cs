using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Dtos.Users.Tasks;
using TaskManager.Models;

namespace TaskManager.Mappers
{
    public static class TasksMappers
    {
        public static TasksDto ToTasksDto(this Tasks tasksModel)
        {
           return new TasksDto{
                Id = tasksModel.Id,
                Name = tasksModel.Name

           };

        }
    }

    public static Tasks ToTasksFromCreateDto(this CreateTasksRequestsDto)
    {
        return new Tasks(

        );
    }
}
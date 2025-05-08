using Microsoft.AspNetCore.Mvc;
using TaskManagerAPI.DTOs.Task;
using TaskManagerAPI.Entities;

namespace TaskManagerAPI.Interfaces
{
    public interface ITaskService
    {
        Task Create(TaskCreateDTO taskCreate);

        Task<List<TaskDTO>> GetTasks();

        Task<TaskDTO> GetById(int id);

        
    }
}

using TaskManagerAPI.Entities;

namespace TaskManagerAPI.Interfaces
{
    public interface ITaskRepository
    {
        Task Create(TaskEntity task);

        Task<TaskEntity> GetById(int id);

        Task<List<TaskEntity>> GetTasks();

        Task<bool> VerifyIfTaskExistsById(int id);

        Task Delete(int id);

        Task Edit(TaskEntity task);
    }
}

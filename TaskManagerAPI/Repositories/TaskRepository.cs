using Microsoft.EntityFrameworkCore;
using TaskManagerAPI.Data;
using TaskManagerAPI.Entities;
using TaskManagerAPI.Interfaces;

namespace TaskManagerAPI.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly AppDbContext _dbContext;

        public TaskRepository(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public async Task Create(TaskEntity task)
        {
            await _dbContext.Tasks.AddAsync(task);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var task = await _dbContext.Tasks.FirstOrDefaultAsync(taskDB => taskDB.Id == id);

            if (task == null)
                throw new Exception("Tarefa não encontrada!");

            _dbContext.Tasks.Remove(task);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Edit(TaskEntity task)
        {
            bool taskExistente = await _dbContext.Tasks.AnyAsync(taskDB => taskDB.Id == task.Id);

            if (!taskExistente)
                throw new Exception("Tarefa não encontrada!");

            _dbContext.Tasks.Update(task);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<TaskEntity> GetById(int id)
        {
            var task = await _dbContext.Tasks.FindAsync(id);
            return task;
        }

        public async Task<List<TaskEntity>> GetTasks()
        {
            var tasks = await _dbContext.Tasks.ToListAsync();
            return tasks;
        }

        public async Task<bool> VerifyIfTaskExistsById(int id)
        {
            var task = await _dbContext.Tasks.FirstOrDefaultAsync(taskDB => taskDB.Id == id);

            if (task != null)
                return true;

            return false;
        
        }
    }
}

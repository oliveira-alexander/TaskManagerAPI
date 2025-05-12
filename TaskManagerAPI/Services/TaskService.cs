using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TaskManagerAPI.Data;
using TaskManagerAPI.DTOs.Task;
using TaskManagerAPI.Entities;
using TaskManagerAPI.Interfaces;

namespace TaskManagerAPI.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            this._taskRepository = taskRepository;
        }

        public async Task Create(TaskCreateDTO taskCreate)
        {
            var task = new TaskEntity()
            {
                Titulo = taskCreate.Titulo,
                Descricao = taskCreate.Descricao,
                Prioridade = Entities.Enums.Prioridade.Media,
                Status = Entities.Enums.Status.Pendente
             };

             await _taskRepository.Create(task);
        }   

        public async Task<List<TaskDTO>> GetTasks()
        {
            var taskList = await _taskRepository.GetTasks();

            List<TaskDTO> taskDTOList = new List<TaskDTO>();

            foreach (var taskDB in taskList)
            {
                var newTaskDTO = new TaskDTO() {
                    Titulo = taskDB.Titulo,
                    Descricao = taskDB.Descricao,
                    Prioridade = taskDB.Prioridade,
                    Status = taskDB.Status
                };

                taskDTOList.Add(newTaskDTO);
            }

            return taskDTOList;
        }

        public async Task<TaskDTO> GetById(int id)
        {
            if (!await _taskRepository.VerifyIfTaskExistsById(id))
                throw new Exception("Tarefa não encontrada!");

            var task = await _taskRepository.GetById(id);

            var taskDTO = new TaskDTO()
            {
                Titulo = task.Titulo,
                Descricao = task.Descricao,
                Prioridade = task.Prioridade,
                Status = task.Status
            };

            return taskDTO;
        }

        public async Task Delete(int id)
        {
            await _taskRepository.Delete(id);
        }

        public async Task Edit(TaskUpdateDTO taskEdit)
        {
            var task = new TaskEntity()
            {
                Id = taskEdit.Id,
                Descricao = taskEdit.Descricao,
                Titulo = taskEdit.Titulo,
                Prioridade = taskEdit.Prioridade,
                Status = taskEdit.Status
            };

           await _taskRepository.Edit(task);
        }
    }
}

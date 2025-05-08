using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManagerAPI.Data;
using TaskManagerAPI.DTOs.Task;
using TaskManagerAPI.Entities;
using TaskManagerAPI.Interfaces;

namespace TaskManagerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class TaskController : ControllerBase
    {
        private readonly ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            this._taskService = taskService;
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(TaskCreateDTO task)
        {
            ApiResponse<TaskCreateDTO> response = new ApiResponse<TaskCreateDTO>();  

            try
            {
                await _taskService.Create(task);

                response.Sucesso = true;
                response.Mensagem = "Tarefa adicionada com sucesso!";
            }
            catch (Exception ex)
            {
                response.Dados = null;
                response.Mensagem = ex.Message;
                response.Sucesso = false;
            }

            return Ok(response);
        }

        [HttpGet("GetTasks")]
        public async Task<IActionResult> GetTasks()
        {
            ApiResponse<List<TaskDTO>> response = new ApiResponse<List<TaskDTO>>();

            try
            {
                List<TaskDTO> taskList = await _taskService.GetTasks();

                if (taskList.Count == 0)
                    throw new Exception("Nenhuma tarefa foi encontrada!");

                response.Sucesso = true;
                response.Dados = taskList;
            }
            catch (Exception ex)
            {
                response.Dados = null;
                response.Mensagem = ex.Message;
                response.Sucesso = false;
            }

            return Ok(response);
        }

        [HttpGet]
        [Route("GetTaskById"+"{id}")]
        public async Task<IActionResult> GetTaskById(int id)
        {
            ApiResponse<TaskDTO> response = new ApiResponse<TaskDTO>();

            try
            {
                if (id == 0)
                    throw new Exception("ID inválido!");

                var task = await _taskService.GetById(id);

                response.Sucesso = true;
                response.Dados = task;
            }
            catch (Exception ex)
            {
                response.Dados = null;
                response.Mensagem = ex.Message;
                response.Sucesso = false;
            }

            return Ok(response);
        }


    }
}

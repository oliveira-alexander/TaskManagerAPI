using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
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

                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpGet("GetTasks")]
        public async Task<IActionResult> GetTasks()
        {
            ApiResponse<List<TaskDTO>> response = new ApiResponse<List<TaskDTO>>();

            List<TaskDTO> taskList = new List<TaskDTO>();
            try
            {
                taskList = await _taskService.GetTasks();

                if (taskList.Count == 0)
                {
                    response.Dados = null;
                    response.Mensagem = "Nenhuma tarefa foi encontrada!";
                    response.Sucesso = false;

                    return NotFound(response);
                }

                response.Sucesso = true;
                response.Dados = taskList;
            }
            catch (Exception ex)
            {
                response.Dados = null;
                response.Mensagem = ex.Message;
                response.Sucesso = false;

                return BadRequest(response);
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
                {
                    response.Dados = null;
                    response.Mensagem = "ID inválido!";
                    response.Sucesso = false;

                    return NotFound(response);
                }
                
                var task = await _taskService.GetById(id);

                response.Sucesso = true;
                response.Dados = task;
            }
            catch (Exception ex)
            {
                response.Dados = null;
                response.Mensagem = ex.Message;
                response.Sucesso = false;

                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            ApiResponse<TaskDTO> response = new ApiResponse<TaskDTO>();

            try
            {
                if (id == 0)
                {
                    response.Dados = null;
                    response.Mensagem = "ID inválido!";
                    response.Sucesso = false;

                    return NotFound(response);
                }

                await _taskService.Delete(id);

                response.Sucesso = true;
                response.Mensagem = "Tarefa removida com sucesso!";
            }
            catch (Exception ex)
            {
                response.Dados = null;
                response.Mensagem = ex.Message;
                response.Sucesso = false;

                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpPut("Edit")]
        public async Task<IActionResult> Edit(TaskUpdateDTO task)
        {
            ApiResponse<TaskDTO> response = new ApiResponse<TaskDTO>();

            try
            {
                await _taskService.Edit(task);
                
                response.Sucesso = true;
                response.Mensagem = "Tarefa alterada com sucesso!";
            }
            catch (Exception ex)
            {
                response.Dados = null;
                response.Mensagem = ex.Message;
                response.Sucesso = false;

                return BadRequest(response);
            }

            return Ok(response);
        }

    }
}

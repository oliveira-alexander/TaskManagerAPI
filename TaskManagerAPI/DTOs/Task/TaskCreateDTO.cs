using System.ComponentModel.DataAnnotations;
using TaskManagerAPI.Entities.Enums;

namespace TaskManagerAPI.DTOs.Task
{
    public class TaskCreateDTO
    {
        [Required (ErrorMessage = "O campo Título é obrigatório!")]
        public string Titulo { get; set; } = string.Empty;

        [Required (ErrorMessage = "A descrição da tarefa é obrigatória!")]
        public string Descricao { get; set; } = string.Empty;
    }
}

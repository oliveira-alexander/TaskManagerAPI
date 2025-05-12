using System.ComponentModel.DataAnnotations;
using TaskManagerAPI.Entities.Enums;

namespace TaskManagerAPI.DTOs.Task
{
    public class TaskUpdateDTO
    {
        [Key]
        [Required(ErrorMessage = "Informe um ID válido!")]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo Título é obrigatório!")]
        public string Titulo { get; set; } = string.Empty;
        [Required(ErrorMessage = "A descrição da tarefa é obrigatória!")]
        public string Descricao { get; set; } = string.Empty;
        [Required (ErrorMessage = "O Status é obrigatório!")]
        [Range(1, 4, ErrorMessage = "Informe um status entre 1 e 4!")]
        public Status Status { get; set; } = Status.Pendente;
        [Required (ErrorMessage = "A prioridade é obrigatória!")]
        [Range(1, 3, ErrorMessage = "Informe uma prioridade entre 1 e 3!")]
        public Prioridade Prioridade { get; set; } = Prioridade.Media;
    }
}

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using TaskManagerAPI.Entities.Enums;

namespace TaskManagerAPI.Entities
{
    public class TaskEntity
    {
        [Key]
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public Status Status { get; set; } = Status.Pendente;
        public Prioridade Prioridade { get; set; } = Prioridade.Media;
    }
}

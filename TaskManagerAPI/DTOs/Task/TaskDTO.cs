using TaskManagerAPI.Entities.Enums;

namespace TaskManagerAPI.DTOs.Task
{
    public class TaskDTO
    {
        public string Titulo { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public Status Status { get; set; } = Status.Pendente;
        public Prioridade Prioridade { get; set; } = Prioridade.Media;
    }
}

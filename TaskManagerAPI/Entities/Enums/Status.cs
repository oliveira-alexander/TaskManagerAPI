using System.ComponentModel.DataAnnotations;

namespace TaskManagerAPI.Entities.Enums
{
    public enum Status
    {
        [Display (Name = "Pendente")]
        Pendente,
        [Display (Name = "Em Andamento")]
        EmAndamento,
        [Display (Name = "Concluída")]
        Concluida,
        [Display (Name = "Cancelada")]
        Cancelada
    }
}

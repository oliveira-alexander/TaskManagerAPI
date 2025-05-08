using System.ComponentModel.DataAnnotations;

namespace TaskManagerAPI.Entities.Enums
{
    public enum Prioridade
    {
        [Display (Name = "Baixa")]
        Baixa,
        [Display (Name = "Média")]
        Media,
        [Display (Name = "Alta")]
        Alta
    }
}

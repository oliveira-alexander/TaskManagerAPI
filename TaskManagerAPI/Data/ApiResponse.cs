namespace TaskManagerAPI.Data
{
    public class ApiResponse <T>
    {
        public bool Sucesso { get; set; } = true;
        public string Mensagem { get; set; } = string.Empty;
        public T? Dados { get; set; }
    }
}

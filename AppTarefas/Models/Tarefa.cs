namespace AppTarefas.Models
{
    public class Tarefa
    {
        // Nome da chave primária deve ser Nome da Classe + "Id"
        public int TarefaId { get; set; } // Id é a chave primária
        public string? Título { get; set; }
        public string? Descrição { get; set; }
        public bool Concluida { get; set; }
    }
}

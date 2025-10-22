var operacoes = new Operacoes();

// Criar uma tarefa
var novaTarefa = new Tarefa
{
    Nome = "Estudar para prova",
    Descricao = "Revisar POO e Banco de Dados",
    DataCriacao = DateTime.Now,
    Status = 1,
    DataExecucao = null
};

int id = operacoes.Criar(novaTarefa);
Console.WriteLine($"Tarefa criada com ID: {id}");

// Alterar a tarefa
novaTarefa.Id = id;
novaTarefa.Status = 2;
novaTarefa.Descricao = "Revisar POO, Banco e MySQL";
operacoes.Alterar(novaTarefa);

// Excluir a tarefa
operacoes.Excluir(id);

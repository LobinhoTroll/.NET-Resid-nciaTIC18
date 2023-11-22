#region Variáveis globais
String titulo,descricao,dataV;
List<Array> tarefasLista  = new List<Array>();
#endregion

#region Funções

void criaTarefas(){
    string[] tarefas = new string[3];
    Console.WriteLine("Informe o titulo da tarefa: ");
    titulo = Console.ReadLine()!;
    tarefas[0] = titulo;    
    Console.WriteLine();

    Console.WriteLine("Informe a descrição da tarefa: ");
    descricao = Console.ReadLine()!;
    tarefas[1] = descricao;
    Console.WriteLine();

    Console.WriteLine("Informe a data de vencimento da tarefa: ");
    dataV = Console.ReadLine()!;
    tarefas[2] = dataV;
    Console.WriteLine();
    
    tarefasLista.Add(tarefas);
}

void listaTarefas(){
    int listnum = 1;
    foreach (var x in tarefasLista){
        Console.WriteLine("Tarefa "+listnum+":");
        Console.WriteLine("Título: "+x.GetValue(0));    
        Console.WriteLine("Descrição: "+x.GetValue(1));
        Console.WriteLine("Data de vencimento: "+x.GetValue(2)+"\n");
        listnum++;
    }    
}
#endregion

criaTarefas();
criaTarefas();
listaTarefas();
#region Variáveis globais
String titulo,descricao,dataV;
List<Array> tarefasLista  = new List<Array>();
#endregion

#region Funções

void criaTarefas(){
    string[] tarefas = new string[4];
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
    
    tarefas[3] = "Pendente";
    tarefasLista.Add(tarefas);
}
void listaTarefas(){
    Console.WriteLine("====Lista====");
    Console.WriteLine();
    int listnum = 1,pend = 0,conc = 0;
    foreach (var x in tarefasLista){
        Console.WriteLine("Tarefa "+listnum+":");
        Console.WriteLine("Título: "+x.GetValue(0));    
        Console.WriteLine("Descrição: "+x.GetValue(1));
        Console.WriteLine("Data de vencimento: "+x.GetValue(2)+"\n");
        Console.WriteLine("Status: "+x.GetValue(3)+"\n");
        listnum++;
    }    
    foreach (var x in tarefasLista){
        string y = x.GetValue(3)!.ToString()!;
        if (y  == "Pendente"){
            pend++;
        }else{
            conc++;
        }
    }
    Console.WriteLine();
    Console.WriteLine("Tarefas pendentes: "+pend);
    Console.WriteLine("Tarefas concluídas: "+conc);
    Console.WriteLine();

    Console.WriteLine("Tarefa mais antiga: "+tarefasLista[0].GetValue(0)!.ToString()!);
    Console.WriteLine("Tarefa mais nova: "+tarefasLista[tarefasLista.Count - 1].GetValue(0)!.ToString()!);
    Console.WriteLine();
}
void listaTarefasPendentes(){
    Console.WriteLine("====Lista====");
    Console.WriteLine();
    int listnum = 0;
    foreach (var x in tarefasLista){
        string y = x.GetValue(3)!.ToString()!;
        if (y  == "Pendente"){
        Console.WriteLine("Tarefa "+(listnum+1)+":");
        Console.WriteLine("Título: "+x.GetValue(0));    
        Console.WriteLine("Descrição: "+x.GetValue(1));
        Console.WriteLine("Data de vencimento: "+x.GetValue(2));
        Console.WriteLine("Status: "+x.GetValue(3)+"\n");   
        listnum++;
        }
    }    
    if (listnum == 0){
        Console.WriteLine("Nenhuma tarefa pendente.");
    }
    Console.WriteLine();
}
void listaTarefasConcluidas(){
    Console.WriteLine("====Lista====");
    Console.WriteLine();
    int listnum = 0;
    foreach (var x in tarefasLista){
        string y = x.GetValue(3)!.ToString()!;
        if (y  != "Pendente"){
        Console.WriteLine("Tarefa "+(listnum+1)+":");
        Console.WriteLine("Título: "+x.GetValue(0));    
        Console.WriteLine("Descrição: "+x.GetValue(1));
        Console.WriteLine("Data de vencimento: "+x.GetValue(2));
        Console.WriteLine("Status: "+x.GetValue(3)+"\n");   
        listnum++;
        }
    }    
    if (listnum == 0){
        Console.WriteLine("Nenhuma tarefa concluída.");
    }
    Console.WriteLine();
}
void excluirTarefas(){
    Console.WriteLine("Informe o titulo da tarefa a ser excluida: ");
    string atv = Console.ReadLine()!;

    foreach (var x in tarefasLista){
        if(x.GetValue(0)!.ToString()! == atv){
            tarefasLista.Remove(x);
        }
    }
    Console.WriteLine();
}
void marcarComoConcluida(){

    Console.WriteLine("Informe o titulo da tarefa a ser marcada como concluida: ");
    string atv = Console.ReadLine()!;
    foreach (var x in tarefasLista){
        if(x.GetValue(0)!.ToString()! == atv){
            x.SetValue("Concluida",3);
        }
    }
    Console.WriteLine();
}

#endregion

void Main(){
    int continuar = 0;
    while (continuar == 0){
        Console.WriteLine("Informe o que deseja fazer:\n 1. Criar \n 2. Marcar como concluida \n 3. Excluir \n 4. Listar todas \n 5. Listar Pendentes \n 6. Listar Concluídas \n 0. Sair");
        Console.Write("Opção escolhida: ");
        int escolha = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine();
        switch (escolha){
            case 1:    
            criaTarefas();
            break;
            case 2:
            marcarComoConcluida();
            break;
            case 3:
            excluirTarefas();
            break;
            case 4:
            listaTarefas();
            break;
            case 5:
            listaTarefasPendentes();
            break;
            case 6:
            listaTarefasConcluidas();
            break;
            case 7:
            break;
        }    
        Console.WriteLine();
        Console.WriteLine("Deseja executar mais alguma operação?: S/0 ou N/1");
        continuar = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine();
    }
}

Main();

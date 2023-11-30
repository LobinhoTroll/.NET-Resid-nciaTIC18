class Veiculo{

//Propriedades

    public string Modelo{ 
        get;
        set;
    }
    public string Ano{
        get;
        set;
    }
    public string Cor{
        get;
        set;
    }
public static void Main(string[] args){
    Veiculo novoVeiculo = new Veiculo();
    
    Console.WriteLine("Informe o modelo do veiculo: ");
    string modelo = Console.ReadLine()!;
    novoVeiculo.Modelo = modelo;
    Console.WriteLine();

    Console.WriteLine("Informe o ano de fabricação do veiculo: ");
    string ano = Console.ReadLine()!;
    novoVeiculo.Ano = ano;
    Console.WriteLine();

    Console.WriteLine("Informe o modelo do veiculo: ");
    string cor = Console.ReadLine()!;
    novoVeiculo.Cor = cor;
    Console.WriteLine();

    Console.WriteLine("Modelo:"+novoVeiculo.Modelo);
    Console.WriteLine("Ano: "+novoVeiculo.Ano);
    Console.WriteLine("Cor"+novoVeiculo.Cor);
}

}




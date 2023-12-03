using System;
internal class Program
{
    List<Tuple<string, string, int, float>> ListaDeProdutos = new List<Tuple<string, string, int, float>>();
    void cadastrarProdutos()
    {
        bool verifp = false, verifq = false;
        float valor;
        int quantidade;

        Console.WriteLine("Informe o nome do produto: ");
        string nome = Console.ReadLine()!;
        Console.WriteLine();

        Console.WriteLine("Informe o código do produto: ");
        bool verifExistenceEnd = false;
        string codigo;
        do
        {
            codigo = Console.ReadLine()!;
            bool verifExistence = ListaDeProdutos.Any(x => x.Item2 == codigo);
            if (verifExistence == false)
            {
                verifExistenceEnd = true;
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Código ja cadastrado informe um codigo valido:");
                Console.WriteLine();
            }
        } while (verifExistenceEnd == false);

        verifq = false;
        Console.WriteLine("Informe a quantidade em estoque do protudo: ");
        do
        {
            try
            {
                quantidade = int.Parse(Console.ReadLine()!);
                verifq = true;
                Console.WriteLine();
            }
            catch (Exception error)
            {
                verifq = false;
                Console.WriteLine();
                Console.WriteLine(error.Message);
                Console.WriteLine("Informe a quantidade novamente: ");
                quantidade = 0;
            }
        } while (verifq == false);

        Console.WriteLine();
        Console.WriteLine("Informe o valor do produto: ");
        do
        {
            try
            {
                valor = float.Parse(Console.ReadLine()!);
                verifp = true;
                Console.WriteLine();
            }
            catch (Exception error)
            {
                verifp = false;
                Console.WriteLine(error.Message);
                Console.WriteLine("Informe o valor do produto novamente: ");
                valor = 0;
            }
        } while (verifp == false);

        var produto = new Tuple<string, string, int, float>(nome, codigo, quantidade, valor);
        ListaDeProdutos.Add(produto);
        Console.WriteLine();
    }
    void buscarPorCodigo()
    {
        Console.WriteLine("Informe o codigo do produto a ser exibido: ");
        string codigo = Console.ReadLine()!;
        bool verifExistence = ListaDeProdutos.Any(x => x.Item2 == codigo);
        if (verifExistence == true)
        {
            foreach (var produto in ListaDeProdutos)
            {
                verifExistence = (produto.Item2 == codigo);
                if (verifExistence == true)
                {
                    Console.WriteLine("Nome do produto: " + produto.Item1);
                    Console.WriteLine("Código do produto: " + produto.Item2);
                    Console.WriteLine("Quantidade em estoque: " + produto.Item3);
                    Console.WriteLine("Valor: " + produto.Item4);
                    Console.WriteLine();
                }
            }
        }
        else
        {
            Console.WriteLine("Código fornecido não consta na lista de produtos cadastrados.");
            Console.WriteLine();
        }
    }
    void atualizaçaoDeEstoque()
    {
        string nome, _codigo;
        int novaQuantidade;
        float valor;
        
        Console.WriteLine("Informe o codigo do produto a a ter sua quantidade alterada: ");
        string codigo = Console.ReadLine()!;
        bool verifExistence = ListaDeProdutos.Any(x => x.Item2 == codigo);
        
        
        if (verifExistence == true)
        {
            foreach (var produto in ListaDeProdutos)
            {
                verifExistence = (produto.Item2 == codigo);
                if (verifExistence == true)
                {
                    nome = produto.Item1;
                    _codigo = produto.Item2;
                    int quantidadeEmEstoque = produto.Item3, quantidade;
                    valor = produto.Item4;

                    Console.WriteLine("Foram adicionados produtos ao estoque?: 0/S ou 1/N");
                    int confirmacao = Convert.ToInt16(Console.ReadLine()!);
                    if (confirmacao == 0)
                    {
                        Console.WriteLine("Informe a quantidade a ser adicionada: ");
                        quantidade = Convert.ToInt32(Console.ReadLine())!;
                    }
                    else
                    {
                        Console.WriteLine("Informe a quantidade a ser retirada: ");
                        quantidade = Convert.ToInt32(Console.ReadLine())!;
                        quantidade *= -1;
                    }
                    novaQuantidade = quantidadeEmEstoque + quantidade;
                    if (novaQuantidade <= -1)
                    {
                        Console.WriteLine("Não é possivel retirar mais items do que a quantidade em estoque.");
                        
                    }else{
                        var produtoAtualizado = new Tuple<string, string, int, float>(nome, _codigo, novaQuantidade, valor);
                        ListaDeProdutos.Add(produtoAtualizado);
                        ListaDeProdutos.Remove(produto);
                        break;
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("Código fornecido não consta na lista de produtos cadastrados.");
            Console.WriteLine();
        }
    }
    void listaProdutosQuantidade()
    {
        Console.WriteLine("Informe a qauntidade maxima em estoque para filtragem dos resultados: ");
        int quanMax = Convert.ToInt32(Console.ReadLine());
        bool verifExistence = ListaDeProdutos.Any(x => x.Item3 <= quanMax);
        if (verifExistence == true)
        {
            List<Tuple<string, string, int, float>> correspondencias = new List<Tuple<string, string, int, float>>();
            
            correspondencias = ListaDeProdutos.Where(x => x.Item3 <= quanMax).ToList();
            int counter = 1;
            foreach (var produto in correspondencias)
            {
                Console.WriteLine(counter + ".");
                Console.WriteLine("Nome: " + produto.Item1);
                Console.WriteLine("Código: " + produto.Item2);
                Console.WriteLine("Quantidade em estoque: " + produto.Item3);
                Console.WriteLine("Valor unitário: " + produto.Item4);
                Console.WriteLine();
                counter += 1;
            }
        }
        else
        {
            Console.WriteLine("Nenhuma item que atende ao critério foi encontrado.");
            Console.WriteLine();
        }

    }
    void listaProdutosFaixaPreco()
    {

        Console.WriteLine("Informe o preço mínimo a filtrar:");
        float min = float.Parse(Console.ReadLine()!);
        Console.WriteLine("Informe o preço maximo a filtrar:");
        float max = float.Parse(Console.ReadLine()!);
        Console.WriteLine();

        bool verifExistence = ListaDeProdutos.Any(x => x.Item4 >= min && x.Item4 <= max);
        if (verifExistence == true)
        {
            var correspondencias = ListaDeProdutos.Where(x => x.Item4 >= min && x.Item4 <= max).ToList();
            int counter = 1;
            foreach (var produto in correspondencias)
            {
                Console.WriteLine(counter + ".");
                Console.WriteLine("Nome: " + produto.Item1);
                Console.WriteLine("Código: " + produto.Item2);
                Console.WriteLine("Quantidade em estoque: " + produto.Item3);
                Console.WriteLine("Valor unitário: " + produto.Item4);
                Console.WriteLine();
                counter += 1;
            }
        }
        else
        {
            Console.WriteLine("Não há produtos com essa faixa de preço. \n");
        }


    }
    void valoresTotais()
    {
        float valorEstoqueTotal = 0, valorEstoqueProduto = 0;
        foreach (var produto in ListaDeProdutos)
        {
            Console.WriteLine("Nome: " + produto.Item1);
            valorEstoqueProduto = produto.Item3 * produto.Item4;
            Console.WriteLine("valor total em estoque: " + valorEstoqueProduto);
            valorEstoqueTotal += valorEstoqueProduto;
            Console.WriteLine();
        }
        Console.WriteLine("valor total do estoque: " + valorEstoqueTotal);
        Console.WriteLine();
    }
    void menu()
    {
        int continuar = 0;
        while (continuar == 0)
        {
            Console.WriteLine("Informe o que deseja fazer:\n 1. Cadastrar produto \n 2. Buscar por código \n 3. Atualizar estoque \n 4. Listar por quantidade maxima \n 5. Listar por faixa de preço \n 6. exibis valores totais do estoque \n 0. Sair");
            Console.Write("Opção escolhida: ");
            int escolha = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();
            switch (escolha)
            {
                case 1:
                    cadastrarProdutos();
                    break;
                case 2:
                    buscarPorCodigo();
                    break;
                case 3:
                    atualizaçaoDeEstoque();
                    break;
                case 4:
                    listaProdutosQuantidade();
                    break;
                case 5:
                    listaProdutosFaixaPreco();
                    break;
                case 6:
                    valoresTotais();
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
    public static void Main(string[] args){
        Program program = new Program();
        program.menu();
    }
}
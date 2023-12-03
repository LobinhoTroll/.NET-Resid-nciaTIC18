using System;
internal class Program
{
    private static void Main(string[] args)
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
            Console.WriteLine(produto.Item1 + " " + produto.Item2 + " " + produto.Item3 + " " + produto.Item4);
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

        cadastrarProdutos();
        buscarPorCodigo();
    }
}
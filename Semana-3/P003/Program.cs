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
            string codigo = Console.ReadLine()!;
            Console.WriteLine();

            Console.WriteLine("Informe a quantidade em estoque do protudo: ");
            do
            {
            try
            {
                quantidade = int.Parse(Console.ReadLine()!);
                verifq = true;
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
            Console.WriteLine(produto.Item1+" "+produto.Item2+" "+produto.Item3+" "+produto.Item4);
            }

    cadastrarProdutos();
}
}
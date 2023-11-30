class Advogado{
    private string Nome,DataNascimento,CPF,CNA;

    public CPF{
        get{
            return (CPF)base.
        }
        set{
        do
        {
        Console.WriteLine("Informe o seu CPF: ");
        string _cpf = Console.ReadLine();
             
        bool ValidarFormatoCPF(string cpf){
        string pattern = @"^\d{3}\.\d{3}\.\d{3}-\d{2}$";
        return Regex.IsMatch(cpf, pattern);
        }
        if(ValidarFormatoCPF(_cpf) == true{
            CPF = _cpf
        }else{
            Console.WriteLine("CPF inválido Informe um cpf no padão xxx.xxx.xxx.-xx");
        }    
        } while (verifFormat == false)
        }
    }

}

class Cliente{
    private string Nome,DataNascimento,CPF,EstadoCivil,Profissao;
}
List<Advogado> advodadosLista = new List<Advogado>();
class Advogado{
    private string Nome,DataNascimento,CPF,CNA;

    public CPF{
        get{
            return (CPF)base.
        }
        set{
        verifFormat = false;
        verifExistenceEnd == false;
        do
        {
            do
        {
        Console.WriteLine("Informe o seu CPF: ");
        string _cpf = Console.ReadLine();
             
        bool ValidarFormatoCPF(string cpf){
        string pattern = @"^\d{3}\.\d{3}\.\d{3}-\d{2}$";
        return Regex.IsMatch(cpf, pattern);
        }
        if(ValidarFormatoCPF(_cpf) == true{
            verifFormat = true;
        }else{
            Console.WriteLine("CPF inválido Informe um cpf no padrão xxx.xxx.xxx.-xx");
        }    
        } while (verifFormat == false)
        
        verifExistence == advodadosLista.Any(x => x.CPF == _cpf);
        if(verifExistence == false){
            CPF = _cpf;
            verifExistenceEnd == true;
        }else{
            Console.WriteLine("CPF ja cadastrado informe um cpf valido");
            verifFormat == false;
            Console.WriteLine();
        }    
        } while (verifExistenceEnd == false)
    }
    public CNA{
        get{
            return (CNA)base.
        };
        set{
        bool ValidarStringNumerica(string cna){
            string pattern = @"^\d{11}$";
            return Regex.IsMatch(cna, pattern);
            }
        };
        bool verifFormat == false;
        bool verifExistenceEnd == false
        do
        {
            do
            {
            Console.WriteLine("Informe o seu CNA: ");
            string _cna = Console.ReadLine(); 
            if ValidarStringNumerica(_cna) == true){
                verifFormat = true;
            }else{
                Console.WriteLine("Formato de CNA invalido");
                Console.WriteLine();
                }
            } while (true);    
            verifExistence == advodadosLista.Any(x => x.CNA == _cna);
            if(verifExistence == false){
            CNA = _cna;
            verifExistenceEnd == true;
            }else{
            Console.WriteLine("CNA ja cadastrado informe um CNA valido");
            verifFormat == false;
            Console.WriteLine();
            } 
        } while (verifExistenceEnd == false)
    }
}

class Cliente{
    private string Nome,DataNascimento,CPF,EstadoCivil,Profissao;
}
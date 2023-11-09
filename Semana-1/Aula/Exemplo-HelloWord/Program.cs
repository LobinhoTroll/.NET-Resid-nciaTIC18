Console.WriteLine("Hello, World! Turma 3\n");

#region Teste de tipos de dados
    
    int tipoInteiro;
    double tipoDouble;
    string tipoString;
    long tipoLong;

    tipoInteiro = int.MaxValue;
    tipoDouble = double.MaxValue;
    tipoLong = long.MaxValue;
    tipoString = "100";
    
    Console.WriteLine("O máximo valor do tipo inteiro é "+tipoInteiro);
    Console.WriteLine("O máximo valor do tipo double é "+tipoDouble);
    Console.WriteLine("O máximo valor do tipo long é "+tipoLong);
    Console.WriteLine("O valor definido no momento para a string é "+tipoString);

    tipoInteiro = int.Parse(tipoString);//tambem podendo usar tipoInteiro = (int)(tipoString);
    Console.WriteLine("O máximo valor do tipo inteiro após o parce da string é "+tipoInteiro+"\n");


#endregion

#region Operadores
/*
    //Aritiméticos
    +,++,+=
    -,--,-=
    *
    /
    %
    \
    ? :
    
    //Relacionais
    >,>=
    >,<=
    ==
    !=
    =
    ===
    
    //Lógicos
    &&
    ||
    !

*/
    tipoInteiro = int.MaxValue;
    tipoDouble = tipoInteiro + tipoLong;
    Console.WriteLine("Converção implícita em tipoDouble = tipoInteiro + tipoLong: "+tipoDouble);

#endregion
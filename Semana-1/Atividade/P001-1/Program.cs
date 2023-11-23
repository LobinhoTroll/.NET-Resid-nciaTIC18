#region Exercício 2
/*Usado por cadão para a maioria dos calculos ex: 2000 - 3478 + 68376
int A = 2000; 
long é bastante usado para cálculos de cunho acadêmico, como científico e estatístico. É comum também usarmos o long int para armazenar números como RG e CPF.
long B = 12312312312; //123.123.123-12
Short é usada para armazenar valores pequenos raramente passando de 100 
short C = 100;
*/
#endregion


#region Exercício 3

    Console.WriteLine("Exercício 3");
    double A = 8.64134234;
    int B;
    B = ((int)A); //converter implicitamente double para int não é possivel(B = A) e o programa não roda, mas com o comando de converção ((int)variavel) é possivel
    Console.WriteLine(B);
    Console.WriteLine("\n");

#endregion


#region Exercício 4
    Console.WriteLine("Exercício 4");
    int x = 10,y = 3;
    Console.WriteLine("Num 1 = 10 e Num 2 = 3");
    Console.WriteLine("Soma: "+(x+y));
    Console.WriteLine("Subtração: "+(x-y));
    Console.WriteLine("Multiplicação: "+(x*y));
    Console.WriteLine("Divisão: "+(x/y));
    Console.WriteLine("\n");

#endregion


#region Exercício 5

    Console.WriteLine("Exercício 5");
    int a = 5,b = 8;
    Console.WriteLine("a > b = "+(a > b));
    Console.WriteLine("\n");

#endregion


#region Exercício 6

    Console.WriteLine("Exercício 6");
    string str1 = "Hello",str2 = "Word";
    Console.WriteLine("str1 + str2 = "+(str1 == str2));
    Console.WriteLine("\n");

#endregion


#region Exercício 7

    Console.WriteLine("Exercício 7");
    bool condicao1 = true,condicao2 = false;
    Console.WriteLine(condicao1+" e "+condicao2 +"\nAmbos são True?");
    if (condicao1 == true && condicao2 == true){
        Console.WriteLine("Resultado: True");    
    }else{
        Console.WriteLine("Resultado: False");
    }
    Console.WriteLine("\n");

#endregion

#region Exercício 8

    Console.WriteLine("Exercício 8");
    int num1 = 7,num2 = 3, num3 = 10;
    Console.WriteLine("num1 = "+num1," num2 = "+num2, " num3 = "+num3);
    Console.WriteLine("num1 > num2: "+(num1 > num2));
    Console.WriteLine("num3 == num1 + num2: "+(num3 == num1 + num2));
    Console.WriteLine("\n");

#endregion
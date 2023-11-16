// #region Exercício 1
// Console.WriteLine("Exercício 1");
// for (int i = 0; i < 30; i++){
//     if (i % 3 == 0||i % 4 == 0){
//         Console.WriteLine(i);    
//     }
// }
// Console.WriteLine("\n"); 
// #endregion
// #region Exercício 2
// Console.WriteLine("Exercício 2");
// int F=1,U=0,P=U+F;
// Console.WriteLine(U+"\n"+F);
// for (int i = 0; i < 100; i++){
//     F = U + P;
//     U = P;
//     P = F;
//     Console.WriteLine(F);
// }
// #endregion
#region Exercício 3

Console.WriteLine("Exercício 3");
for (int i = 1; i <= 8; i++){
    
    for (int j = 1; j <= i; j++){
        if (j!=i){
            Console.Write(i*j+",");
        }else{
        Console.Write(i*j+".");   
        }
    }
    Console.Write("\n");
}
#endregion
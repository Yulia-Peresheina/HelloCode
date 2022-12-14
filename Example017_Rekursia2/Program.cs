// // Собрать строку с числами от A до B, при условии, что А меньше или равно В

// string Numbers(int a, int b)
// {
//     string result = string.Empty;
//     for (int i = a; i <= b; i++)
//         result = result + $"{i}";
//     return result;
// }

// Console.WriteLine(Numbers(3, 7));

// Собрать строку с числами от A до B, при условии, что А меньше или равно В
// string NumbersRekursia(int a, int b)
// {
//     if (a < b) return $"{a} " + NumbersRekursia(a + 1, b);
//     else
//     {
//         if (a == b) return $"{b}" + String.Empty;
//         else return String.Empty;
//     }

// }

// Console.WriteLine(NumbersRekursia(8, 7));

// сумма чисел от 1 до n

// int SumRekursia(int n)
// {
//     if  ( n >= 1) return n + SumRekursia(n - 1);
//     else return 0;
// }
// Console.WriteLine(SumRekursia(5)); //1 + 2 + 3 + 4 +5

// возведение a в степерь n

// int PovRekursia(int a, int n)
// {
//     if (n == 0) return 1;
//     else return a * PovRekursia(a, n - 1);
// }
//Console.WriteLine(PovRekursia(4, 4));

int PowerRekursiaMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRekursiaMath(a * a, n/ 2);
    else return a * PowerRekursiaMath(a, n - 1);

}
Console.WriteLine(PowerRekursiaMath(4, 4));

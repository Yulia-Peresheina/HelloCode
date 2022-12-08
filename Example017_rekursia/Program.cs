//Написать рекурсивную функцию для вычисления факториала

// int Factorial(int N)
// {
//     if (N == 1)
//         return 1;
//     else
//         return N * Factorial(N - 1);
// }
// Console.WriteLine(Factorial(6));



//Написать рекурсивную функцию для последовательности Фибоначчи

int Fibonachchi (int n)
{
    if(n == 1 || n == 2)
        return 1;
    else
        return Fibonachchi(n-1) + Fibonachchi(n - 2);
}

for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"({i}) = {Fibonachchi(i)}");
}
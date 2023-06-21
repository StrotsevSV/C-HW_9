// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.WriteLine("!1! - Задайте значения M и N\n!2! - Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N");

// прромпт 
// создать переменные
// создать цикл для суммирования

int Prompt (string message)
{
    int rezult = 0;
    try
    {
        Console.Write(message);
        rezult = int.Parse(Console.ReadLine());
    }
    catch 
    {
        Prompt("Ошибка в методе Prompt, попробуйте снова: ");
    }
    return rezult;
}

int M = Prompt("Задайте значения M - ");
int N = Prompt("Задайте значения N - ");
int sum = Sum(M,N);
Console.Write($"M = {M}; N = {N} -> {sum}");

int Sum(int M, int N)
{
   if (M > N )
        return 0;
    else
        return M + Sum(M + 1, N);
}

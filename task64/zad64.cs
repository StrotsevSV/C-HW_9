// Задача 64: 
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"

Console.Clear();
Console.WriteLine($"!1! - задайте 2 переменные\n!2! - выведете все натуральные числа в диапазоне между переменных");

int Prompt(string message)
{
    int rezult = 0;
    try
    {
        Console.Write(message);
        rezult = int.Parse(Console.ReadLine()!);
    }
    catch
    {
        Console.WriteLine("ошибка в методе Prompt");
    }
    return rezult;
}

int M = Prompt("Задайте переменную M - ");
int N = Prompt("Задайте переменную N - ");
Console.Write($"M = {M}; N = {N}. -> ");
Math(M,N);


void Math(int M, int N)
{
    if (M<=N)
    {
        Console.Write(M+", ");Math(M+1,N);
    }
}








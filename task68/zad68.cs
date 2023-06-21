//  Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.Write("!1! - вычисления функции Аккермана\n!2! - с помощью рекурсии\n!3! - Даны два неотрицательных числа m и n.");

int Prompt(string message)
{
    int result = 0;
        try
        {
            Console.Write(message);
            result = int.Parse(Console.ReadLine());
        }
        catch{Prompt("ошибка ввода данных!"+message);}
    return result;
}
int m = Prompt("\n- Задайте значение M: ");
int n = Prompt("- Задайте значение N: ");

int result = Ackermann(m,n);
Console.WriteLine($"Ackermann({m}, {n}) = {result}");

    int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else if (m > 0 && n > 0)
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
        return -1;
    }

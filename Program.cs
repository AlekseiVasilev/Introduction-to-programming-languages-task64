// Задача 64:
// Задайте значение N. Напишите программу,
// которая выведет все чётные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "4, 2"
// N = 8 -> "8, 6, 4, 2"

Console.Clear();
Console.WriteLine("\t Задача №64");
Console.WriteLine("Введите число N");
int n = Math.Abs(int.Parse(Console.ReadLine() ?? string.Empty));
Console.WriteLine(Numbers(n));

string Numbers(int n)
{
    if (n > 0)
    {
        if (n % 2 == 0 && n > 0)
        {
            Console.Write($"{n}, ");
            return Numbers(n - 2);
        }
        if (n % 2 != 0 && n > 0)
        {
            n = n - 1;
            Console.Write($"{n}, ");
            return Numbers(n - 2);
        }
        else
        {
            Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
            Console.WriteLine("  ");
            return "";
        }
    }
    else
    {
        Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
        Console.WriteLine("  ");
        return "";
    }
}

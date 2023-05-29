/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int Prompt(string message)
{
    System.Console.Write(message);
    bool isNumber = int.TryParse(Console.ReadLine(), out int result);
    if (!isNumber)
    {
        Console.WriteLine("It is not an integer.");
        return -1;
    }
    return result;
}

int N = Prompt("N = ");

if (N != -1)
{
    for (int i = 0; i < N; i++)
    {
        Console.Write($"{Math.Pow((i + 1), 3)}\t");
    }
}

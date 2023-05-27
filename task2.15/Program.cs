/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

int Prompt(string message)
{
    System.Console.Write(message);
    bool isNumber = int.TryParse(Console.ReadLine(), out int result);
    if (isNumber == false)
    {
        Console.WriteLine("It is not an integer.");
    }
    return result;
}

int day = Prompt("Input index day of the week: ");
int[] array = {1, 2, 3, 4, 5, 6, 7};

if (array.Contains(day))
{
    if (day > 5)
    {
        Console.WriteLine("Yes, it's a weekend!");
    }
    else
    {
        Console.WriteLine("No, you should go to work");
    }
}
else
{
    Console.WriteLine("It's not a day of the week =/");
}

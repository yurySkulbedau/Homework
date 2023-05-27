/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
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

int number = Prompt("Input number: ");

if (number < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    while (number > 999)
    {
        number /= 10;
    }
    number %= 10;
    Console.WriteLine("Third digit is " + number);
}

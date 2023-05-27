/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

// Console.Write("Input 3-digit number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number < 100 || number > 999)
// {
//     Console.WriteLine(number + " isn't 3-digit number");
//     return;
// }

// int secondRank = number / 10 % 10;
// Console.WriteLine("Second digit is " + secondRank);

int Prompt(string message)
{
    System.Console.Write(message);
    bool isNumber = int.TryParse(Console.ReadLine(), out int result);
    if (isNumber == false)
    {
        Console.WriteLine("It is not an integer");
    }
    return result;
}

int number = Prompt("Input 3-digit number: ");
if (number < 100 || number > 999)
{
    Console.WriteLine(number + " isn't 3-digit number");
    return;
}

int secondRank = number / 10 % 10;
Console.WriteLine("Second digit is " + secondRank);

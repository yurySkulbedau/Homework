/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 || number > 999)
{
    Console.WriteLine(number + " isn't 3-digit number");
}

number /= 10;
number %= 10;
Console.WriteLine("Second digit is " + number);

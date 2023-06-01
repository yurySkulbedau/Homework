/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int CalcDigitSum(int number)
{
    int sum = 0;
    while (number != 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}


Console.Write("Input number: ");
string? input = Console.ReadLine();
if (int.TryParse(input, out int number))
{
    int digitSum = CalcDigitSum(number);
    Console.WriteLine($"sum of digits in the number {input} is equal to {digitSum}");
}
else Console.WriteLine("It is not an integer!");

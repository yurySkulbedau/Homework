/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

int digitNumber = 5; // число разрядов на случай более универсального решения

bool IsPalindrome(string number)
{
    int length = number.Length;
    for (int i = 0; i < length / 2; i++)
    {
        if (number[i] != number[length - 1 - i])
        {
            return false;
        }
    }
    return true;
}


Console.Write($"Input {digitNumber}-digit number: ");
string input = Console.ReadLine();

if (!int.TryParse(input, out int number))
{
    Console.WriteLine("It is not an integer.");
    return;
}

if (input.Length == digitNumber)
{
    if (IsPalindrome(input))
    {
        Console.WriteLine("It's a palindrome.");
    }
    else
    {
        Console.WriteLine("It's not a palindrome.");
    }
}
else
{
    Console.WriteLine($"It is not a {digitNumber}-digit number.");
}

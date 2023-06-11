/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

double Prompt(string message)
{
    Console.Write(message);
    double number;
    while (!double.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Ivvalid value. Please enter a valid number: ");
    }
    return number;
}

void PrintArray(double[] arr)
{
    Console.WriteLine($"[{string.Join(", ", arr)}]");
}

int CountPositiveNumbers(double[] arr)
{
    int count = 0;
    foreach (var item in arr)
    {
        if (item > 0)
        {
            count++;
        }
    }
    return count;
}


int arrayLength = 5;
double[] arrayOfNumbers = new double[arrayLength];
Console.WriteLine($"Please enter {arrayLength} numbers: ");

for (int i = 0; i < arrayLength; i++)
{
    arrayOfNumbers[i] = Prompt("");
}

Console.Write($"There are {CountPositiveNumbers(arrayOfNumbers)} positive numbers in array ");
PrintArray(arrayOfNumbers);

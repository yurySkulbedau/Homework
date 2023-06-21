/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int PromptPositiveInt(string message)
{
    int number;
    bool isInputValid;
    do
    {
        Console.Write(message);
        isInputValid = int.TryParse(Console.ReadLine(), out number) && number > 0;
        if (!isInputValid)
        {
            Console.Write("Invalid value. ");
        }
    } while (!isInputValid);

    return number;
}

/// <summary>
/// Printing a sequence of numbers from start to end
/// </summary>
/// <param name="start"> left edge of the numerical range </param>
/// <param name="end"> right edge </param>
/// <returns> line wuth numbers from start to end </returns>
string GetNumberString(int start, int end)
{
    if (start == end) return start.ToString();
    else if (start < end) return start + ", " + GetNumberString(start + 1, end);
    return start + ", " + GetNumberString(start - 1, end);
}

int N = PromptPositiveInt("Enter a natural number: ");
Console.WriteLine(GetNumberString(N, 1));

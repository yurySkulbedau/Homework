/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
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

int SumInRange(int firstNumber, int secondNumber)
{
    if (firstNumber == secondNumber) return firstNumber;
    else if (firstNumber < secondNumber) return firstNumber + SumInRange(firstNumber + 1, secondNumber);
    return secondNumber + SumInRange(firstNumber, secondNumber + 1);
}


int M = PromptPositiveInt("Enter natural number M: ");
int N = PromptPositiveInt("Enter natural number N: ");
Console.WriteLine($"The sum of natural elements between M and N: {SumInRange(M, N)}");

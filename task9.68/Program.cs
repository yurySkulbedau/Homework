/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int PromptNonnegativeInt(string message)
{
    int number;
    bool isInputValid;
    do
    {
        Console.Write(message);
        isInputValid = int.TryParse(Console.ReadLine(), out number) && number >= 0;
        if (!isInputValid)
        {
            Console.Write("Invalid value. ");
        }
    } while (!isInputValid);

    return number;
}

int Ackermann(int m, int n)
{
    if (m == 0) 
    {
        return n + 1;
    }
    else if (n == 0) 
    {
        return Ackermann(m - 1, 1);
    }
    return Ackermann(m - 1, Ackermann(m, n - 1));
}


int m = PromptNonnegativeInt("Enter nonnegative integer m: ");
int n = PromptNonnegativeInt("Enter nonnegative integer n: ");
Console.WriteLine($"Ackermann function A({m}, {n}) = {Ackermann(m, n)}");

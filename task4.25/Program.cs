/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int Prompt(string message)
{
    Console.Write(message);
    if (!int.TryParse(Console.ReadLine(), out int result))
    {
        Console.WriteLine("It is not an integer!");
        return -1;
    }
    return result;
}

int NaturalPower(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result *= a;
    }
    return result;
}


int A = Prompt("Input A: ");
int B = Prompt("Input B: ");
if (A != -1 && B != -1)
{
    int power = NaturalPower(A, B);
    Console.WriteLine($"{A} to the power of {B} is equal to {power}");
}

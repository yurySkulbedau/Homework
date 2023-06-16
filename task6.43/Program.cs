/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
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

void FindIntersection(double b1, double b2, double k1, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"The point of intersection: ({x}, {y})");
}

bool IsValidate(double k1, double k2)
{
    return k1 != k2;
}


Console.WriteLine("For an equation like y = k*x + b, enter the coefficients k and b");
double b1 = Prompt("Enter b1: ");
double k1 = Prompt("Enter k1: ");
double b2 = Prompt("Enter b2: ");
double k2 = Prompt("Enter k2: ");

if (IsValidate(k1, k2))
{
    FindIntersection(b1, b2, k1, k2);
}
else
{
    Console.WriteLine("There is no point of intersection");
}

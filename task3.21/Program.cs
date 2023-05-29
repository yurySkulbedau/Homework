/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

int Prompt(string message)
{
    System.Console.Write(message);
    bool isNumber = int.TryParse(Console.ReadLine(), out int result);
    if (!isNumber)
    {
        Console.WriteLine("It is not an integer.");
        return -1;
    }
    return result;
}

Console.WriteLine("Input the coordinates of point A");
int xA = Prompt("x: ");
int yA = Prompt("y: ");
int zA = Prompt("z: ");
Console.WriteLine("Input the coordinates of point B");
int xB = Prompt("x: ");
int yB = Prompt("y: ");
int zB = Prompt("z: ");

int[] array = {xA, xB, yA, yB, zA, zB}; 

if (array.Contains(-1))
{
    Console.WriteLine("Restart please");
}
else
{
    double distance = Math.Sqrt(Math.Pow((xA-xB), 2) + Math.Pow((yA-yB), 2) + Math.Pow((zA-zB), 2));
    Console.WriteLine($"The distance between the points is equal to {Math.Round(distance, 2)}");
}

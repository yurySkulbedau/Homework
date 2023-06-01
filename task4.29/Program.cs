/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int Prompt(string message)
{
    Console.Write(message);
    if (int.TryParse(Console.ReadLine(), out int result))
    {
        return result;
    }
    return -1;
}

int[] CreateIntArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Prompt($"Input {i} symbol: ");
        if (array[i] == -1) 
        {
            Console.WriteLine("What do u do?! It's not an integer! Restart");
            return null;
        }
    }
    return array;
}

int[] CreateRandomIntArray(int size, int maxValue)
{
    Random rndm = new Random();
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = rndm.Next(maxValue);
    }
    return array;
}

double[] CreateRandomDoubleArray(int size, double maxValue)
{
    Random rndm = new Random();
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rndm.NextDouble() * maxValue, 2);
    }
    return array;
}


int arraySize = 8;

Console.WriteLine("which way do you want to set the array (1 - with console; 2 - randomly; 3 - randomly (real numbers))? ");
string? answer = Console.ReadLine();
if (answer == "1")
{
    int[] array = CreateIntArray(arraySize);
    if (array != null) 
    {
        Console.Write($"[{String.Join(", ", array)}]");
    }
}
else if (answer == "2")
{
    int[] array = CreateRandomIntArray(arraySize, 99);
    Console.Write($"[{String.Join(", ", array)}]");
}
else if (answer == "3")
{
    double[] doubleArray = CreateRandomDoubleArray(arraySize, 100);
    Console.Write($"[{String.Join("\t", doubleArray)}]");
}
else Console.WriteLine("Next time try to choose correctly");

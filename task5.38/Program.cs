/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

double Prompt(string message)
{
    Console.Write(message);
    double number;
    while(!double.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Ivvalid value. Please enter a valid number: ");
    }
    return number;
}


double[] GetArray(int size)
{
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = Prompt($"Enter the {i + 1} element of the array: ");
    }
    Console.WriteLine($"Array: [{String.Join("; ", arr)}]");
    return arr;
}


double[] GetRandomArray(int size, double minValue, double maxValue)
{
    Random rndm = new Random();
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(rndm.NextDouble() * (maxValue - minValue) + minValue, 2);
    }
    Console.WriteLine($"Array: [{String.Join("; ", arr)}]");
    return arr;
}


double FindMax(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) 
        {
            max = arr[i];
        }       
    }
    return max;
}

double FindMin(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) 
        {
            min = arr[i];
        }       
    }
    return min;
}


int arraySize = 5;
double[] array;
Console.WriteLine("Press 'y' if you want to fill the array yourself");
string? answer = Console.ReadLine();
if (answer == "y")
{
    array = GetArray(arraySize);
}
else 
{
    array = GetRandomArray(arraySize, -100, 100); 
}

double arrayMax = FindMax(array);
double arrayMin = FindMin(array);

Console.WriteLine($"the difference between the maximum ({arrayMax}) and minimum ({arrayMin}) elements of the array = {arrayMax - arrayMin}");

/* Задача 34: Задайте массив, заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] GetRandomIntArray(int size, int minValue, int maxValue)
{
    Random rndm = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = rndm.Next(minValue, maxValue + 1);
    }
    Console.WriteLine($"Array: [{String.Join(", ", arr)}]");
    return arr;
}

int CountEvenNumbers(int[] arr)
{
    int count = 0;
    foreach(int num in arr)
    {
        if (num % 2 == 0) 
        {
            count++;
        }
    }
    return count;
}

int arraySize = 8;
int[] array = GetRandomIntArray(arraySize, 100, 999);
int evenNumbers = CountEvenNumbers(array);

Console.WriteLine($"Number of even integers: {evenNumbers}");

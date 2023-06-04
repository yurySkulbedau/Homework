/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int Prompt(string message)
{
    Console.Write(message);
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Invalid input. Please enter a valid integer: ");
    }
    return number;
}


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


int arraySize = 8;
int minValue = Prompt("Enter the minimum value: ");
int maxValue = Prompt("Enter the maximum value: ");
int[] array = GetRandomIntArray(arraySize, minValue, maxValue);

int sum = 0;
for (int i = 0; i < arraySize; i++)
{
    if (i % 2 == 1)
    {
        sum += array[i];
    }
}

Console.WriteLine($"Sum of elements at odd positions: {sum}");

/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3
*/

int PromptPositiveInt(string message)
{
    int number = 0;
    bool isInputValid = false;
    while (!isInputValid)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out number) && number > 0)
        {
            isInputValid = true;
        }
        else
        {
            Console.Write("Ivvalid value. ");
        }
    }
    return number;
}

int[,] GetRandomMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = random.Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine("The matrix:");
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

double[] FindAverageColumn(int[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    double[] averageColumn = new double[columns];
    for (int i = 0; i < columns; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            averageColumn[i] += arr[j, i];
        }
        averageColumn[i] /= rows;
    }
    return averageColumn;
}

void PrintArray(double[] arr, string sep = "\t")
{
    Console.WriteLine(string.Join(sep, arr));
}


int rows = PromptPositiveInt("Enter the number of rows for the matrix: ");
int columns = PromptPositiveInt("Enter the number of columns for the matrix: ");

int minValue = -10;
int maxValue = 10;

int[,] table = GetRandomMatrix(rows, columns, minValue, maxValue);
PrintMatrix(table);

double[] averageColumn = FindAverageColumn(table);

Console.Write($"The average of each column:\n");
PrintArray(averageColumn);

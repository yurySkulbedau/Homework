/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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
            Console.Write("Invalid value. ");
        }
    }
    return number;
}


double[,] GetRandomMatrix(int rows, int columns, double min, double max)
{
    double[,] matrix = new double[rows, columns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = random.NextDouble() * (max - min) + min;
        }
    }
    return matrix;
}


void PrintMatrix(double[,] matrix)
{
    Console.WriteLine("The matrix:");
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{matrix[i, j]:f2}\t");
        }
        Console.WriteLine();
    }
}


int FindIndexOfMin(double[] array)
{
    double minValue = array[0];
    int resIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minValue)
        {
            minValue = array[i];
            resIndex = i;
        }
    }
    return resIndex;
}


int rowCount = PromptPositiveInt("Enter the number of rows for the matrix: ");
int columnCount = PromptPositiveInt("Enter the number of columns for the matrix: ");

int minValue = -10;
int maxValue = 10;

double[,] table = GetRandomMatrix(rowCount, columnCount, minValue, maxValue);
PrintMatrix(table);

double[] rowSums = new double[rowCount];
for (int i = 0; i < rowCount; i++)
{
    double sum = 0;
    for (int j = 0; j < columnCount; j++)
    {
        sum += table[i, j];
    }
    rowSums[i] = sum;
}

// Console.WriteLine($"Array: [{String.Join(", ", rowSums)}]");
Console.WriteLine($"Строка с наименьшей суммой элементов: #{FindIndexOfMin(rowSums) + 1}");

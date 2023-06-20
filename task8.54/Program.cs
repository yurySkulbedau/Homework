/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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


double[] SortArrayDown(double[] array)
{
    double tmp;
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[i])
            {
                tmp = array[i];
                array[i] = array[j];
                array[j] = tmp;
            }
        }
    }
    return array;
}


int rowCount = PromptPositiveInt("Enter the number of rows for the matrix: ");
int columnCount = PromptPositiveInt("Enter the number of columns for the matrix: ");

int minValue = -10;
int maxValue = 10;

double[,] table = GetRandomMatrix(rowCount, columnCount, minValue, maxValue);
PrintMatrix(table);

double[] tmpArray = new double[columnCount];
for (int i = 0; i < rowCount; i++)
{
    for (int j = 0; j < columnCount; j++)
    {
        tmpArray[j] = table[i, j];
    }
    tmpArray = SortArrayDown(tmpArray);
    for (int j = 0; j < columnCount; j++)
    {
        table[i, j] = tmpArray[j];
    }
}

Console.WriteLine("Result:");
PrintMatrix(table);

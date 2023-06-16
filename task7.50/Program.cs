/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
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


int rows = PromptPositiveInt("Enter the number of rows for the matrix: ");
int columns = PromptPositiveInt("Enter the number of columns for the matrix: ");

double minValue = -100;
double maxValue = 100;

double[,] table = GetRandomMatrix(rows, columns, minValue, maxValue);
PrintMatrix(table);

Console.WriteLine("\nEnter the position of an element in a two-dimensional array");
int row = PromptPositiveInt("Row: ") - 1;
int column = PromptPositiveInt("Column: ") - 1;

if (row <= rows && column <= columns)
{
    Console.WriteLine($"({row + 1}, {column + 1}): {table[row, column]:f2}");
}
else 
{
    Console.WriteLine("There is no such element in the matrix");
}
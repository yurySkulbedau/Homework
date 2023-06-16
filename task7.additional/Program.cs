/* Дополнительное:
Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
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

double GetDiagonalSum(double[,] matrix)
{
    int diagonalLength = Math.min(matrix.GetLength(0), matrix.GetLength(1));
    double sum = 0;
    for (int i = 0; i < diagonalLength; i++)
    {
        sum += matrix[i, i];
    }
    return sum;
}


int rows = PromptPositiveInt("Enter the number of rows for the matrix: ");
int columns = PromptPositiveInt("Enter the number of columns for the matrix: ");

int minValue = -10;
int maxValue = 10;

double[,] table = GetRandomMatrix(rows, columns, minValue, maxValue);
PrintMatrix(table);

double diagonalSum = GetDiagonalSum(table);
Console.WriteLine($"The sum of the elements of the main diagonal: {diagonalSum:f2}");

/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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


int[,] GetIntRandomMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = random.Next(min, max + 1);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matrix, string message = "The matrix:")
{
    Console.WriteLine(message);
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


bool IsValidMatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    if (matrixA.GetLength(1) == matrixB.GetLength(0))
    {
        return true;
    }
    return false;
}


int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int[,] resMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                resMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return resMatrix;
}


int firstMatrixRowCount = PromptPositiveInt("Enter the number of rows for the matrix A: ");
int firstMatrixColumnCount = PromptPositiveInt("Enter the number of columns for the matrix A: ");
int secondMatrixRowCount = PromptPositiveInt("Enter the number of rows for the matrix B: ");
int secondMatrixColumnCount = PromptPositiveInt("Enter the number of columns for the matrix B: ");

int minValue = -10;
int maxValue = 10;

int[,] matrixA = GetIntRandomMatrix(firstMatrixRowCount, firstMatrixColumnCount, minValue, maxValue);
PrintMatrix(matrixA, "The matrix A:");
int[,] matrixB = GetIntRandomMatrix(secondMatrixRowCount, secondMatrixColumnCount, minValue, maxValue);
PrintMatrix(matrixB, "The matrix B:");

if (IsValidMatrixMultiplication(matrixA, matrixB))
{
    PrintMatrix(MatrixMultiplication(matrixA, matrixB), "Matrix Multiplication:");
}
else Console.WriteLine("Matrix multiplication is impossible");

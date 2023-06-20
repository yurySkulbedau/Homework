/* ДОПОЛНИТЕЛЬНАЯ. Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int size = 6; // задавай любой размер
int[,] matrix = new int[size, size];
int number = 1;

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


void FillMatrix(int[,] matrix)
{
    int minRow = 0;
    int maxRow = matrix.GetLength(0) - 1;
    int minCol = 0;
    int maxCol = matrix.GetLength(1) - 1;

    while (minCol <= maxCol)
    {
        // Fill right
        for (int j = minCol; j <= maxCol; j++)
        {
            matrix[minRow, j] = number;
            number++;
        }
        if (minCol == maxCol) break;
        minRow++;

        // Fill down
        for (int i = minRow; i <= maxRow; i++)
        {
            matrix[i, maxCol] = number;
            number++;
        }
        maxCol--;

        // Fill left
        for (int j = maxCol; j >= minCol; j--)
        {
            matrix[maxRow, j] = number;
            number++;
        }
        if (minCol == maxCol) break;
        maxRow--;

        // Fill up
        for (int i = maxRow; i >= minRow; i--)
        {
            matrix[i, minCol] = number;
            number++;
        }
        minCol++;
    }
}

FillMatrix(matrix);
PrintMatrix(matrix);

/* ДОПОЛНИТЕЛЬНАЯ. Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int size = 7; // задавай любой размер
int[,] matrix = new int[size, size];
int number = 1;
int count = size; // на какое кол-во клеток закрашивать
int coordinateI = 0;
int coordinateJ = 0;

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

bool AreNumbersIn(int number, int[,] arr2D)
{
    foreach (int element in arr2D)
    {
        if (element == number)
        {
            return true; // element found
        }
    }
    return false; // element NOT found
}


void FillRight(int i, int initJ)
{
    for (int j = initJ; j < initJ + count; j++)
    {
        matrix[i, j] = number;
        number++;
        coordinateJ = j;
    }
    count--;
    coordinateI++;
}

void FillDown(int initI, int j)
{
    for (int i = initI; i < initI + count; i++)
    {
        matrix[i, j] = number;
        number++;
        coordinateI = i;
    }
    coordinateJ--;
}

void FillLeft(int i, int initJ)
{
    for (int j = initJ; j > initJ - count; j--)
    {
        matrix[i, j] = number;
        number++;
        coordinateJ = j;
    }
    count--;
    coordinateI--;
}

void FillUp(int initI, int j)
{
    for (int i = initI; i > initI - count; i--)
    {
        matrix[i, j] = number;
        number++;
        coordinateI = i;
    }
    coordinateJ++;
}


while (AreNumbersIn(0, matrix))
{
    FillRight(coordinateI, coordinateJ);
    FillDown(coordinateI, coordinateJ);
    FillLeft(coordinateI, coordinateJ);
    FillUp(coordinateI, coordinateJ);
}

PrintMatrix(matrix);

/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

int PromptPositiveInt(string message)
{
    int number = 0; // переменная number инициализируется значением по умолчанию (0) перед входом в цикл while, 
                    // чтобы удовлетворить требования компилятора
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


int rows = PromptPositiveInt("Enter the number of lines: ");
int columns = PromptPositiveInt("Enter the number of columns: ");

double minValue = -100;
double maxValue = 100;

double[,] table = GetRandomMatrix(rows, columns, minValue, maxValue);
PrintMatrix(table);

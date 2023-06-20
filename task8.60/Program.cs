/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

bool IsElementUnique(int number, int[,,] arr3D)
{
    foreach (int element in arr3D)
    {
        if (element == number)
        {
            return false; // element found
        }
    }
    return true; // element NOT found
}


int Prompt2DigitUniqueInt(int[,,] arr3D, string message = "Input number: ")
{
    int number = 0;
    bool isInputValid = false;
    while (!isInputValid)
    {
        Console.Write(message);
        isInputValid = int.TryParse(Console.ReadLine(), out number) && number > 9 && number < 100;
        if (!isInputValid)
        {
            Console.Write("Invalid value. ");
        }
        else if (!IsElementUnique(number, arr3D))
        {
            Console.Write("Number already exist in the array. ");
            isInputValid = false;
        }
    }
    return number;
}


int[,,] GetCubeArray(int size)
{
    int[,,] arr3D = new int[size, size, size];
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            for (int k = 0; k < size; k++)
            {
                arr3D[i, j, k] = Prompt2DigitUniqueInt(arr3D);
            }
        }
    }
    return arr3D;
}


void Print3dArray(int[,,] arr3D)
{
    for (int i = 0; i < arr3D.GetLength(0); i++)
    {
        for (int j = 0; j < arr3D.GetLength(1); j++)
        {
            for (int k = 0; k < arr3D.GetLength(2); k++)
            {
                Console.WriteLine($"{arr3D[i, j, k]} ({i},{j},{k})");
            }
        }
    }
}


int[,,] cubeArray = GetCubeArray(2);
Print3dArray(cubeArray);

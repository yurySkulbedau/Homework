﻿/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Write("Input the first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the third number: ");
int c = Convert.ToInt32(Console.ReadLine());
int maximum = a;

if (a < b) maximum = b;
if (maximum < c) maximum = c;

Console.WriteLine("Maximum number is " + maximum);

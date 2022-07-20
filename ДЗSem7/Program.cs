// Задача 47 Задайте двумерный массив m x n, заполненный случайными
// вещественными числами.
/*
double[,] CreateRandom2dArray(int rows, int columns, double minValue, double maxValue)
{
    Random random = new Random();
    double[,] newArray = new double[rows, columns];

    for(int i = 0; i < rows; i++) 
        for(int j = 0; j < columns; j++) 
            newArray[i,j] =  random.NextDouble() * (maxValue - minValue) + minValue;

    return newArray;        
}

void Show2Array(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write("{0,6:F2}", array[i,j]);

    Console.WriteLine();        
    }
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minValue: ");
double min = Convert.ToDouble(Console.ReadLine());
Console.Write("Input maxValue: ");
double max = Convert.ToDouble(Console.ReadLine());

double[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2Array(myArray);
*/

//Задача 50 Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве и возвращает значение этого элемента
// или указание, что его нет.
/*
double[,] CreateRandom2dArray(int rows, int columns, double minValue, double maxValue)
{
    Random random = new Random();
    double[,] newArray = new double[rows, columns];

    for(int i = 0; i < rows; i++) 
        for(int j = 0; j < columns; j++) 
            newArray[i,j] =  random.NextDouble() * (maxValue - minValue) + minValue;

    return newArray;        
}

void Show2Array(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write("{0,6:F2}", array[i,j]);

    Console.WriteLine();        
    }
}

double FindElement(double[,] array, int row, int col)
{
    double Result = 0;
    if (col < array.GetLength(1) && row < array.GetLength(0) && col > 0 && row > 0)
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            if(i == row - 1)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    if (j == col - 1)
                    {
                        Result = array[i,j];
                    }
                }
            }
        }
        return Result;
    }
    else
    {
        return Result;
    }
    
}


Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minValue: ");
double min = Convert.ToDouble(Console.ReadLine());
Console.Write("Input maxValue: ");
double max = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Row: ");
int Row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Column: ");
int Column = Convert.ToInt32(Console.ReadLine());


double[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2Array(myArray);
if (FindElement(myArray, Row, Column) == 0)
{
    Console.WriteLine("Requested element doesn't exist in current array.");
}
else
{
    Console.Write("Requested element is ");
    Console.WriteLine("{0,6:F2}", FindElement(myArray, Row, Column));
}
*/

// Задача 52 Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++) 
        for(int j = 0; j < columns; j++) 
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);

    return newArray;        
}

void Show2Array(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

    Console.WriteLine();        
    }
}

string AllColumnsAverageValue(int[,] array)
{
    double average = 0;
    string Result = "";
    for(int j = 0; j < array.GetLength(1); j++)
    {
        average = 0;
        for(int i = 0; i < array.GetLength(0); i++)
        {
            average += array[i,j]; 
        }
        average /= array.GetLength(0);
        Result = Result + average + "; ";
    }
    return Result;
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minValue: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maxValue: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2Array(myArray);
Console.WriteLine();
Console.WriteLine($"Average values in each column are: {AllColumnsAverageValue(myArray)}");

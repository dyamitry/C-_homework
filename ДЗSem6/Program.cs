// Задача 41 Пользователь с клавиатуры вводит М чисел, посчитайте
// сколько чисел больше 0 ввёл пользователь.
//Метод, позволяющий пользователю ввести в массив регулируемого
//размера вещественные числа в качестве элементов.
/*
double[] CreateDoubleArray(int m)
{
    double[] newArray = new double[m];

    Console.WriteLine("Array initialisation.");

    for(int current = 0; current < m; current++)
    {
        Console.Write($"Input element #{current + 1}: ");
        newArray[current] = Convert.ToDouble(Console.ReadLine());
    }
    return(newArray);
}
//Метод для подсчёта чисел больше "0" 
int CountPositiveDouble(double[] array)
{
    int Sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            Sum++;
        }
    }
    return(Sum);
}
Console.WriteLine("Input positive integer numbers that will act as (array size): ");
int num = Convert.ToInt32(Console.ReadLine());
double[] array = CreateDoubleArray(num);
Console.WriteLine($"The quantity of positive numbers is {CountPositiveDouble(array)} ");
*/
//Задача Напишите программу, к-я найдёт точку пересечения двух прямых,
//заданных уравнениями у=k1*x+b1, y=k2*x+b2; значения b1, k1, b2? k2
//задаются пользователем.
// x=(b2-b1)/(k1-k2)
Console.WriteLine("Input k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine($"The required point coordinates are: ({x}, {y})");




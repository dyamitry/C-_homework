// Задача 34 Задайте массив, заполненный случайными трёхзначными
// положительными числами. Напишите программу, к-я покажет кол-во 
// чётных чисел в массиве.

/*
//Метод, инициирующий создание массива размера size из случайных 
//положительных трёхзначных чисел
int[] CreateRandomArray(int size)
{
    int[] newArray = new int[size];

    Console.WriteLine("Array initialisation.");

    for(int current = 0; current < size; current++)
    {
        newArray[current] = new Random().Next(100, 1000);
        //В текущий элемент массива newArray[current] записывается
        // случайное число из интервала от 100 до 999
    }
    return(newArray);
}
//Метод, определяющий количество чётных элементов массива
int EvenQuantity(int[] array)
{
    int EQ;
    EQ = 0;
    for(int current = 0; current < array.Length; current++)
    {
        if(array[current] % 2 == 0)
        {
            EQ++;
        }
    }
    return(EQ);
}
//Метод для вывода всех элементов массива на экран
string DemonstrateArray(int[] array)
{
    string S = "[";

    for(int i = 0; i < array.Length; i++)
    {
        S = S + " " + array[i];
    }
    S = S + " ]";
    return(S);
}
//основная программа
Console.Write("Input positive integer number that will act as array size: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num < 0)
{
    Console.WriteLine("The inputed array size may not be a negative number.");
}
else
{
    if (num <= 20) //Проверка на целесообразность вывода массива на экран
    {
        int[] array = CreateRandomArray(num);
        Console.WriteLine($"Your array is: {DemonstrateArray(array)}.");
        Console.WriteLine($"The quantity of even numbers in current random array (size of {num}) is {EvenQuantity(array)}");    
    }
    else
    {
        int[] array = CreateRandomArray(num);
        Console.WriteLine($"The quantity of even numbers in current random array (size of {num}) is {EvenQuantity(array)}");
    }
}
*/

// Задача 36 Задайте одномерный массив заполненный случайными 
// числами. Найдите сумму элементов стоящих на нечётных позициях.
/*
//Создание массива случайных чисел, лежащих в пределах 
//Min <= x < Max
int[] CreateArray(int size, int Max, int Min)
{
    int[] newArray = new int[size];

    Console.WriteLine("Array initialisation.");

    for(int current = 0; current < size; current++)
    {
        Random x = new Random();
        int n = x.Next(Min, Max);
        newArray[current] = n;
        //В текущий элемент массива newArray[current] записывается
        // случайное число
    }
    return(newArray);
}
// Метод, суммирующий элементы массива, стоящие на нечётных позицияхю
int OddPositionedNumbersSumm(int[] array)
{
    int Summ = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 > 0)
        {
            Summ = Summ + array [i];
        }
    }
    return(Summ);
}
//Метод для вывода всех элементов массива на экран
string DemonstrateArray(int[] array)
{
    string S = "[";

    for(int i = 0; i < array.Length; i++)
    {
        S = S + " " + array[i];
    }
    S = S + " ]";
    return(S);
}
//основная программа
Console.WriteLine("Input positive integer numbers that will act as (array size), (Max value - 1) and (Min value): ");
int size = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());
int min = Convert.ToInt32(Console.ReadLine());
if(size < 0)
{
    Console.WriteLine("The inputed array size may not be a negative number.");
}
else
{
    if (size <= 20) //Проверка на целесообразность вывода массива на экран
    {
        int[] array = CreateArray(size, max, min);
        Console.WriteLine($"Your array is: {DemonstrateArray(array)}.");
        Console.WriteLine($"The summ of numbers with odd positions in current random array (size of {size}) is {OddPositionedNumbersSumm(array)}");    
    }
    else
    {
        int[] array = CreateArray(size, max, min);
        Console.WriteLine($"The summ of numbers with odd positions in current random array (size of {size}) is {OddPositionedNumbersSumm(array)}");
    }
}
*/

// Задача 38 Задайте массив вещественных чисел. Найдите разницу
// между максимальным и минимальным элементами массива.

//Метод, позволяющий пользователю ввести в массив регулируемого
//размера вещественные числа в качестве элементов.
double[] CreateDoubleArray(int m)
{
    double[] newArray = new double[m];

    Console.WriteLine("Array initialisation.");

    for(int current = 0; current < m; current++)
    {
        Console.Write($"Input element #{current + 1}: ");
        newArray[current] = Double.Parse(Console.ReadLine());
    }
    return(newArray);
}
//Метод для поиска максимума 
double MaxDouble(double[] array)
{
    double Max = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > Max)
        {
            Max = array[i];
        }
    }
    return(Max);
}
//Метод для поиска минимума 
double MinDouble(double[] array)
{
    double Min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < Min)
        {
            Min = array[i];
        }
    }
    return(Min);
}


//Метод для вывода всех элементов массива на экран
string DemonstrateArray(double[] array)
{
    string S = "[";

    for(int i = 0; i < array.Length; i++)
    {
        S = S + " " + array[i];
    }
    S = S + " ]";
    return(S);
}

//основная программа
Console.WriteLine("Input positive integer numbers that will act as (array size): ");
int size = Convert.ToInt32(Console.ReadLine());
if(size < 0)
{
    Console.WriteLine("The inputed array size may not be a negative number.");
}
else
{
    if (size <= 20) //Проверка на целесообразность вывода массива на экран
    {
        double[] array = CreateDoubleArray(size);
        Console.WriteLine($"Your array is: {DemonstrateArray(array)}.");
        Console.WriteLine($"The difference between (Max value) and (Min value) in current random array (size of {size}) is {MaxDouble(array) - MinDouble(array)}");    
    }
    else
    {
        double[] array = CreateDoubleArray(size);
        Console.WriteLine($"The difference between (Max value) and (Min value) in current random array (size of {size}) is {MaxDouble(array) - MinDouble(array)}");
    }
}
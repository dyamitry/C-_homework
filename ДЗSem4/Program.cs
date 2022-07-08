// Задача 27 Напишите программу, к-я принимает на вход число
// и выдаёт сумму цифр в числе.
/*
int DigitSumm(int a)
{
    int current;
    current = 0;

     if(a < 0)
    {
        a = a *(-1);
        while (a / 10 > 0)
        {
        current = current + a % 10;
        a = a / 10;
        } 
        current = (current + a) * (-1);
        return(current);
    }
    else
    {
         while (a / 10 > 0)
         {
        current = current + a % 10;
        a = a / 10;
        } 
        current = current + a;
        return(current);
    }
}
Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The summ of digits in number ({num}) equals {DigitSumm(num)}.");
*/

// Задача 29 Напишите программу, к-я задаёт массив из m злементов
// и выводит их на экран.

int[] CreateArray(int m)
{
    int[] newArray = new int[m];

    Console.WriteLine("Array initialisation.");

    for(int current = 0; current < m; current++)
    {
        Console.Write($"Input element #{current + 1}: ");
        newArray[current] = Convert.ToInt32(Console.ReadLine());
    }
    return(newArray);
}

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

Console.Write("Input positive integer number that will act as array size: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num < 0)
{
    Console.WriteLine("The inputed array size may not be a negative number.");
}
else
{
    int[] array = CreateArray(num);
    Console.WriteLine($"Your array is: {DemonstrateArray(array)}.");
}


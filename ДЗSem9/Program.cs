//Задайте значение N. Напишите программу, которая найдет кол-во цифр 
//в числе N рекурсивным методом.



int NumbersQuantity(int N)
{
    if(N > 10)
    {
        return 1 + NumbersQuantity(N / 10);

    }
    return 1;
}
Console.Write("Input a number: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The number {N} consists of {NumbersQuantity(N)} digits");



// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных(!) элементов в промежутке от M до N.

/*
int SumNM(int n, int m)
{
    if(m > n || (n < 0 && m < 0))
    {
        return 0;
    }
    else
    {
        if(n > m || n > 0)
        {
            return n + SumNM(n - 1, m);
        }
        else return n;
    }
}
Console.Write("Input the bigger number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the smaller number: ");
int m = Convert.ToInt32(Console.ReadLine());
if(SumNM(n, m) == 0)
{
    Console.WriteLine("Incorrect numbers.");
}
else
{
    Console.WriteLine($"The sum of natural numbers between {n} and {m} is {SumNM(n,m)}");
}
Console.WriteLine();
*/
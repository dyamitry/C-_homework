//Задача 19 Напишите программу, к-я принимает на вход
// число и проверяет, является ли оно палиндромом.
/*
int DigitsInNumber(int a)
{
    int counter1, current;
    current = a;
    counter1 = 1;
   
    if(a < 0)
    {
        a = a *(-1);
    }

    while(a / 10 > 0)
    {
        counter1 = counter1 + 1;
        a = a / 10;
    }
    return counter1;
}

int Palindrome(int input)
{
    int current;
    current = input;
    
    if ((input / 10000 == input % 10) && (input / 1000 % 10 == input % 100 / 10))
    {
         current = 1;
         return(current);
    }
    else
    {
        current = 0;
        return(current);
    }
}

Console.Write("Input positive integer number which contains 5 digits: ");
int num = Convert.ToInt32(Console.ReadLine());

if(DigitsInNumber(num) == 5)
{
    if(Palindrome(num) == 1)
    {
        Console.WriteLine($"Your number ({num}) is a palindrome.");
    }
    else
    {
        Console.WriteLine($"Your number ({num}) is not a palindrome.");
    }
}
else
{
    Console.WriteLine($"Your number ({num}) does not contain 5 digits.");
}
*/

// Задача 23 Напишите программу, к-я принимает число (N) и выдаёт 
// таблицу кубов чисер от 1 до (N).

string RowGradeN_3(int N)
{
    string S;
    S = "";

    
    if(N < 0)
    {
        while(N + 1 <= 2)
        {
            S = N * N * N + ", " + S;
            N = N + 1; 
        }
        return(S);
    }
    else
    {
        while(N - 1 >= 0)
        {
            S = N * N * N + ", " + S;
            N = N - 1; 
        }
        return(S);
    }
}

Console.Write("Input final number of row that will contain all integer numbers (n^3): ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Requested row is: " + RowGradeN_3(num));
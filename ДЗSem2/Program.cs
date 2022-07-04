// задача 10 
//Напишите программу, к-я принимает на вход трёхзначное число и
// показывает на выходе вторую цифру этого числа.

/*

int SecondNumber()
{
    int input, res;

    Console.WriteLine("Input a number between 100 and 999 or between -100 and -999");
    input = Convert.ToInt32(Console.ReadLine());

    if((input > 99 && input <= 999) || (input < -99 && input >= -999))
    {
        res = input % 100;
        res = res / 10;
        return(res);
    }
    else
    {
        if((input<10 && input >=0) || (input<0 && input >-10))
        {
            input = input + 1000;
            return(input);
        }
        else
        {
            return(input);
        }
    }
}

int SecNum = SecondNumber();
if(SecNum / 10 == 0)
{
    Console.WriteLine("Requested number is " + SecNum);
}
else
{
     Console.WriteLine("Requested number is not a 3 digit number.");
}
*/
// Задача 13
// Напишите программу, к-я выдаёт третью цифру заданного числа или
// сообщает, что третьей цифры нет.

/*
int ThirdNumber1()
{
    int input, division, number, counter1, counter2;

    Console.WriteLine("Input a number.");
    input = Convert.ToInt32(Console.ReadLine());

    number = input;
    counter1 = 0;
    if(input < 0)
    {
        input = input * (-1);
    }
    while(input / 10 > 0)
    {
        counter1 = counter1 + 1;
        input = input / 10;
    }

    division = 1;
    if(counter1 < 2)
    {
        number = 1000;
        return(number);
    }
    while(counter1 > 0)
    {
        counter1 = counter1 - 1;
        division = division * 10;
    }

    counter2 = 0;

    while (counter2 < 2)
    {
        counter2 = counter2 +1;
        number = number % division;
        division = division / 10;
    }
    number = number / division;
    return(number);
}
int Result = ThirdNumber1();
if (Result == 1000)
{
    Console.WriteLine("There is no third number");
}
else
{
    Console.WriteLine("The requested number is " + Result);    
}
*/



/*
int ThirdNumber2()
{
    int input, division, counter1, current;

    Console.WriteLine("Input a number.");
    input = Convert.ToInt32(Console.ReadLine());

    current = input;
    counter1 = 1;
   
    if(input < 0)
    {
        input = input * (-1);
    }

    while(input / 10 > 0)
    {
        counter1 = counter1 + 1;
        input = input / 10;
    }
    division = 1;
    while(counter1 - 3 > 0)
    {
        division = division * 10;
        counter1 = counter1 - 1;
    }
    if(current / 100 == 0)
    {
        current = 100;
        return(current);
    }
    else
    { 
        current = (current / division) % 10;
        return(current);
    }
}

int number = ThirdNumber2();
if(number == 100)
{
    Console.WriteLine("There is no third digit.");
}
else
{
    Console.WriteLine("The third digit is " + number);
}
*/

// Задача 15
// Напишите программу, к-я принимает на вход цифру, обозначающую
// день недели и проверяет, является ли этот день выходным.
/*
int Weekend()
{
    int input, Result;

    Console.WriteLine("Enter the number of day in a week. (1 to 7)");
    input = Convert.ToInt32(Console.ReadLine());

    if(input == 6 || input == 7)
    {
        Result = 1;
        return(Result);
    }
    else
    {
        if(input < 1 || input > 7)
        {
            Result = -1;
            return(Result);
        }
        else
        {
            Result = 0;
            return(Result);
        }
        
    }
}

int number = Weekend();
if(number == 1)
{
    Console.WriteLine("The day of week number is a holiday.");
}
else
{
    if (number == -1)
    {
        Console.WriteLine("The day of week number is incorrect. It has to be allocated between 1 and 7.");
    }
    else
    {
        Console.WriteLine("The day of week number is not a holiday.");
    }
    
}
*/
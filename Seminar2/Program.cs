/*int CutNumber()
{
    int num = new Random().Next(100,1000);
    Console.WriteLine("Current random number is " + num);

    int sotni = num / 100;
    int Ed = num % 10;

    int result = sotni * 10 + Ed;
    return result;
}

void CutNumberVoid()
{
    int num = new Random().Next(100,1000);
    Console.WriteLine("Current random number is " + num);

    int sotni = num / 100;
    int Ed = num % 10;

    int result = sotni * 10 + Ed;
    Console.WriteLine("Result number is " + result);
}

CutNumberVoid();
*/
/*
int maxnumberXY()
{
    int input, des, ed, output;

    input = new Random().Next(10,99);

    ed = input % 10;
    des = input / 10;

    if(des > ed)
    {
        output = des;
    }
    else
    {
        output = ed;
    }
    return(output);
}
int number = maxnumberXY();
Console.WriteLine("Your number is " + number);
*/
//Принимаем на вход число и проверяет кратно ли оно одновременно 7 и 23
/*
int kratno7_23()
{
    int input, kratno7, kratno23, result;
    Console.WriteLine("Input a number");
    input = Convert.ToInt32(Console.ReadLine());

    if(input % 7 > 0) 
    {
        kratno7 = 0;
        result = 0;
        return(result);
    }
    else
    {
        kratno7 = 1;
        if(input % 23 == 0)
        {
            kratno23 = 1;
            result = 1;
            return(result);
        }
        else
        {
            kratno23 = 0;
            result = 0;
            return(result);
        }
    }
}

int number = kratno7_23();
if(number == 1)
{
   Console.WriteLine("Input number is a multiple of both 23 and 7."); 
}
else
{
    Console.WriteLine("Input number is not a multiple of both 23 and 7.");
}
*/
// написать программу, к-я принимает на вход два числа и проверяет является ли одно число квадратом другого.
/*
int Square1()
{
    int input1, input2, result;

    Console.Write("Input first number ");
    input1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input second number ");
    input2 = Convert.ToInt32(Console.ReadLine());

    if(input1 * input1 == input2)
    {
        result = 1;
        return(result);
    }
    else
    {
        if(input2 * input2 == input1)
        {
            result = 1;
            return(result);
        }
        else
        {
            result = 0;
            return(result);
        }
    }
}

int number = Square1();
if(number == 1)
{
    Console.WriteLine("One number is a square of another.");
}
else
{
    Console.WriteLine("No number is a square of another.");
}
*/
 
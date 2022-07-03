//Задача №2

/*
int input1, input2;

Console.WriteLine("Input first number.");
input1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number.");
input2 = Convert.ToInt32(Console.ReadLine());

if(input1 > input2)
{
    Console.WriteLine("First number (" + input1 + ") is bigger than second number (" + input2 + ")");
}
else
{
    Console.WriteLine("Second number (" + input2 + ") is bigger than first number (" + input1 + ")");
}
*/



//Задача №4

/*
int max, input1, input2, input3;

Console.WriteLine("Input first number.");
input1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number.");
input2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input third number.");
input3 = Convert.ToInt32(Console.ReadLine());

if(input1 > input2)
{
    max = input1;
}
else
{
    max = input2;
}
if(max > input3)
{
    Console.WriteLine("Current maximal number is " + max);
}
else
{
    Console.WriteLine("Current maximal number is " + input3);
}
*/



//Задача №6

/*
int input1, test1;

Console.WriteLine("Input number.");
input1 = Convert.ToInt32(Console.ReadLine());

test1 = input1 % 2;

if(test1 * test1 > 0)
{
    Console.WriteLine("Number (" + input1 + ") is odd");
}
else
{
    Console.WriteLine("Number (" + input1 + ") is even");
}
*/


//Задача №8
/*
int N, current;

Console.WriteLine("Input number N");
N = Convert.ToInt32(Console.ReadLine());

current = 2;

if(N < 0)
{
    Console.WriteLine("Unfortunately, N is negative and this software works only with positive numbers.");
}
else
{
    Console.Write("Requested numbers are ");
    while(current <= N)
    {
        Console.Write(current + ", ");
        current = current + 2;
    }
}
/*
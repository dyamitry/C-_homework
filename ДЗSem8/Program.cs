// Задача 54 Задайте двумерный массив. Напишите программу, к-я
// упорядочит по убыванию элементы каждой строки массива.
/*
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

int[,] SortArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int[] MyArray = new int[array.GetLength(1)];
        for (int j = 0; j < array.GetLength(1); j++)
        {
            MyArray[j] = array[i,j];  
        }
        Array.Sort(MyArray);
        Array.Reverse(MyArray);
        for (int z = 0; z < array.GetLength(1); z++)
        {
            array[i,z] = MyArray[z];  
        }
    }
    return array;
}
*/

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
Show2Array(SortArray(myArray));

// Задача 56 Задайте прямоугольный двумерный массив. Напишите
// программу, к-я будет находить строку с наименьшей суммой элементов.
/*
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

int RowSum(int[,] array, int row)
{
    int sum = 0;
    for(int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[row,j];
    }
    return sum;
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
int MinSum = RowSum(myArray, 0), Row = 0;
for (int i = 0; i < myArray.GetLength(0); i++)
{
    if (MinSum > RowSum(myArray, i))
    {
        MinSum = RowSum(myArray, i);
        Row = i + 1;
    }
}
Console.WriteLine($"Minimal sum of row in current array is {MinSum} and it is located at row {Row}");
*/
// Задача 62 Заполните спирально массив 4 на 4.
/*
void Show2Array(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

    Console.WriteLine();        
    }
}

int RectangleCounter(int[,] array)
{
    int RectangleCount = 0, xStart = 0, xFinish = array.GetLength(1) - 1, yStart = 0, yFinish = array.GetLength(0) - 1;
    while (xStart < xFinish && yStart < yFinish)
    {
        xStart++;
        --xFinish;
        yStart++;
        --yFinish;
        RectangleCount += 4;
    }
    if(xStart == xFinish)
        RectangleCount++;
    if(yStart == yFinish)
        RectangleCount += 2;
    return RectangleCount;
}

int[,] SpiralArray(int[,] array, int Height, int Width, int Start, int MaxMoveLimiter)
{   
    int GlobalCounter = 0; // Количество необходимых перемещений без смены направления
    int x = 0, y = 0; // Текущие координаты
    int Up = Height - 1, Down = 0, Left = Width - 1, Right = 0; //Счётчики хода для каждого направления
    int LocalCounter = 0; //Счётчик элементов, используется для последовательного увеличения на 1
    int MoveLimiter = 1; // Число раз, когда произойдёт смена направлений для текущего случая
    while (MoveLimiter <=MaxMoveLimiter) // Цикл, который ограничивает максимальное число движений без перемены направления
    {
        if (GlobalCounter % 4 == 0) // Каждый четвёртый цикл - горизонтальный слева направо
        {
            for (y = Right; y < array.GetLength(1) - Right; y++) //вычитаем из кол-ва столбцов счётчик хода
            {
                array[x, y] = Start + LocalCounter;
                Console.WriteLine($"This is step {LocalCounter} and current x is ({x}) and y is ({y}), while element value is {array[x,y]}, Right value is {Right}, Left value is {Left}, Down value is {Down}, Up value is {Up}");
                LocalCounter++;
            }
            --y; //Не знаю, почему, но последний провальный шаг for всё равно добавляет 1 в y. Здесь это компенсируется.
            Right++; //В счётчик движений слева направо добавили 1. В следующий раз перебор пройдёт без крайнего правого и крайнего левого элемента
            GlobalCounter++; //В индикатор количества перемещений без изменения направления прописываем +1, так как перемещение завершено
            Console.WriteLine($"{GlobalCounter} sequence is succesful and current x is {x} and y is {y}");
        }
        else
        {
            if ((GlobalCounter - 1) % 4 == 0) // Каждый четвёртый цикл со смещением в 1 - вертикальный сверху вниз
            {
               
                for (x = Down + 1; x < array.GetLength(0) - Down; x++) //вычитаем из кол-ва столбцов счётчик хода. Для того, чтобы не записаться в предыдущий элемент, нужно сдвинуться по вертикали
                {
                    array[x, y] = Start + LocalCounter;
                    Console.WriteLine($"This is step {LocalCounter} and current x is ({x}) and y is ({y}), while element value is {array[x,y]}, Right value is {Right}, Left value is {Left}, Down value is {Down}, Up value is {Up}");
                    LocalCounter++;
                }
                --x;
                Down++;
                GlobalCounter++;
                Console.WriteLine($"{GlobalCounter} sequence is succesful and current x is {x} and y is {y}");
            }
            else
            {
                if ((GlobalCounter - 2) % 4 == 0) // Каждый четвёртый цикл со смещением в 2 - горизонтальный слева направо
                {
                    for (y = Left - 1; y >= array.GetLength(1) - 1 - Left; --y) //вычитаем из кол-ва столбцов счётчик хода
                    {
                        array[x, y] = Start + LocalCounter;
                        Console.WriteLine($"This is step {LocalCounter} and current x is ({x}) and y is ({y}), while element value is {array[x,y]}, Right value is {Right}, Left value is {Left}, Down value is {Down}, Up value is {Up}");
                        LocalCounter++;
                    }
                    y++;
                    --x;
                    --Left;
                    GlobalCounter++;
                    Console.WriteLine($"{GlobalCounter} sequence is succesful and current x is {x} and y is {y}");
                }
                 else
                {
                    if ((GlobalCounter - 3) % 4 == 0) // Каждый четвёртый цикл со смещением в 3 - вертикальный снизу вверх
                    {
                        for (x = Up - 1; x > array.GetLength(0) - 1 - Up; --x) //вычитаем из кол-ва столбцов счётчик хода
                        {
                            array[x, y] = Start + LocalCounter;
                            Console.WriteLine($"This is step {LocalCounter} and current x is ({x}) and y is ({y}), while element value is {array[x,y]}, Right value is {Right}, Left value is {Left}, Down value is {Down}, Up value is {Up}");
                            LocalCounter++;
                        }
                        y++;
                        --Up;
                        GlobalCounter++;
                        Console.WriteLine($"{GlobalCounter} sequence is succesful and current x is {x} and y is {y}");
                        x++;
                    }
                }
            }
        }
        MoveLimiter++; 
    }
    return array;

}

Console.Write("Input square array width: ");
int Width = Convert.ToInt32(Console.ReadLine());
Console.Write("Input square array height: ");
int Height = Convert.ToInt32(Console.ReadLine());
Console.Write("Input starting number in the array: ");
int Start = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] MyArray = new int[Width,Height];    
int LinesQuantity = RectangleCounter(MyArray);
if(LinesQuantity % 4 == 0)
{
    MyArray = SpiralArray(MyArray, Height, Width, Start, LinesQuantity);
    Show2Array(MyArray);
}
else
{
    Console.WriteLine("Unfortunately, the current array isn't square.");
}
*/



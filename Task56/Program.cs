// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FillRand2dArray(int[,] fillArray)
{
    for (int i = 0; i < fillArray.GetLength(0); i++)
        for (int j = 0; j < fillArray.GetLength(1); j++)
            fillArray[i, j] = new Random().Next(-9, 10);
}

void Print2dArray(int[,] printArray)
{
    for (int i = 0; i < printArray.GetLength(0); i++)
    {
        for (int j = 0; j < printArray.GetLength(1); j++)
            Console.Write($"{printArray[i, j],4}");
        Console.WriteLine();
    }
}

void RowWithMinSum(int[,] rowArray)
{
    int iMin = 0;
    int minSum = 0;
    for (int j = 0; j < rowArray.GetLength(1); j++)
        minSum+= rowArray[0,j];
        
    int sum = 0;
    for (int i = 0; i < rowArray.GetLength(0); i++)
    {
        for (int j = 0; j < rowArray.GetLength(1); j++)
            sum += rowArray[i, j];
        if (sum < minSum)
        {
            minSum = sum;
            iMin = i;
        }
        sum = 0;
    }
    Console.WriteLine($"The row with minimum sum of element is {iMin+1}");
}

Console.Write("Enter the 1d size: ");
int d1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the 2d size: ");
int d2 = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[d1, d2];
FillRand2dArray(array);
Print2dArray(array);
RowWithMinSum(array);
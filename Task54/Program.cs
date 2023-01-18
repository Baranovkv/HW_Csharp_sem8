// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void RowSort2d(int[,] sortArray)
{
    for (int i = 0; i < sortArray.GetLength(0); i++)
        for (int j = 0; j < sortArray.GetLength(1)-1; j++)
            if (sortArray[i,j] < sortArray[i,j+1])
                (sortArray[i,j], sortArray[i,j+1]) = (sortArray[i,j+1], sortArray[i,j]);
}

Console.Write("Enter the 1d size: ");
int d1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the 2d size: ");
int d2 = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[d1, d2];
FillRand2dArray(array);
Print2dArray(array);
Console.WriteLine("Sorted array: ");
RowSort2d(array);
Print2dArray(array);
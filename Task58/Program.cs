// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

void Prod2Array(int[,] prodArray, int[,] secArray)
{
    for (int i = 0; i < prodArray.GetLength(0); i++)
        for (int j = 0; j < prodArray.GetLength(1); j++)
            prodArray[i,j] *= secArray[i,j];
}

Console.Write("Enter the 1d size: ");
int d1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the 2d size: ");
int d2 = Convert.ToInt32(Console.ReadLine());
int[,] array1 = new int[d1, d2];
int[,] array2 = new int[d1, d2];
FillRand2dArray(array1);
Print2dArray(array1);
Console.WriteLine();
FillRand2dArray(array2);
Print2dArray(array2);
Console.WriteLine();
Prod2Array(array1, array2);
Console.WriteLine("Matrix after multiplication: ");
Print2dArray(array1);
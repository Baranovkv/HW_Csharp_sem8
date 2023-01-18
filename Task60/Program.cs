// Задача 60. ...Сформируйте трёхмерный массив из уникальных двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void FillUniq3dArray(int[,,] fillArray)
{
    int[] uniqArray = new int[fillArray.Length]; // create the array with unique numbers
    uniqArray[0] = new Random().Next(10,100);
    int temp = new Random().Next(10,100);
    for (int i = 1; i < uniqArray.Length; i++)
        {
            for (int j = i; j > 0; j--)
                while (temp == uniqArray[j-1])
                {
                    temp = new Random().Next(10,100);
                    j = i;
                }
        uniqArray[i] = temp;
        }

    int l = 0;
    for (int i = 0; i < fillArray.GetLength(0); i++)    // collect 3d array from 1d array with unique numbers
        for (int j  = 0; j < fillArray.GetLength(1); j++)
            for (int k  = 0; k < fillArray.GetLength(2); k++)
            {
                fillArray[i,j,k] = uniqArray[l];
                l++;                
            }
}

void Print3dArray(int[,,] printArray)
{
    for (int i = 0; i < printArray.GetLength(0); i++)
    {
        for (int j = 0; j < printArray.GetLength(1); j++)
        {
            for (int k = 0; k < printArray.GetLength(2); k++)
                Console.Write($"{printArray[i, j, k]}({i},{j},{k}) ");
            Console.WriteLine();
        }
    }
}
Console.Write("Enter the 1d size: ");
int d1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the 2d size: ");
int d2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the 3d size: ");
int d3 = Convert.ToInt32(Console.ReadLine());
int[,,] array = new int [d1,d2,d3];
FillUniq3dArray(array);
Print3dArray(array);

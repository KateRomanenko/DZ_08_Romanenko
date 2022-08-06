
/* Задача 54: Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива.
*/

/* void CreateArray2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-9, 10);
        }
    }
}
void PrintInt2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void PrintInt3(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"array[{i}, {j}, {k}] = {array[i, j, k]}");
            }
        }
    }
}
void InsertSort(int[,] mass) 
{
int key = 0;
int temp = 0;
for (int i = 0; i < mass.GetLength(0); i++)
{
for (int j = 0; j < mass.GetLength(1) - 1; j++)
{
key = j + 1;
temp = mass[i, key];
for (int k = j + 1; k > 0; k--)
{
    if (temp > mass[i, k - 1])
{
mass[i, k] = mass[i, k-1];
key = k - 1;
}
}
mass[i, key] = temp;
}
}
}

Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m,n];
CreateArray2(array);
PrintInt2(array);
InsertSort(array);
PrintInt2(array);
*/

/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов.
*/

void CreateArray2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-9, 10);
        }
    }
}
void PrintInt2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void PrintInt3(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"array[{i}, {j}, {k}] = {array[i, j, k]}");
            }
        }
    }
}

Console.Write("Введите количество строк массива: ");
int m2 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n2 = int.Parse(Console.ReadLine());
int[,] array2 = new int[m2,n2];
CreateArray2(array2);
PrintInt2(array2);
int sum = 999999999;
int minSumI = -1;
for (int i = 0; i < array2.GetLength(0); i++)
{
    int sumRow = 0;
    for (int j = 0; j < array2.GetLength(1); j++)
    
    {
      sumRow += array2[i,j];
    }
    if (sumRow < sum)
    {
        sum = sumRow;
        minSumI = i;
    }
 }
 Console.WriteLine("Индекс строки с наименьшей сумоой элементов: " + minSumI); 





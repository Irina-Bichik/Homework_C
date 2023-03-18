// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] FillMatrixWithRandom(int row, int column)
{
    double[,] array = new double[row, column];
    Random rnd = new Random();  
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100,100))/100; 
        }
    }
    return array;
}

void PrintMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Write("Input the number of rows: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number of columns: ");
int column = Convert.ToInt32(Console.ReadLine());
double[,] matrix = FillMatrixWithRandom(row, column);
PrintMatrix(matrix);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Variant 1

int[,] FillMatrixWithRandom(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-100, 101);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Input the number to search for: ");
int search = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number of rows: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number of columns: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixWithRandom(row, column);
PrintMatrix(matrix);

string result = $"Number {search} not found";

for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == search)
            {
                result = $"Number {search} is found";
                break;
            }
        }
    }
   Console.WriteLine(result);

// Variant 2

int[,] FillMatrixWithRandom(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-100, 101);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Input the row index to search for: ");
int rowSearch = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the column index to search for: ");
int columnSearch = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the number of rows: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number of columns: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixWithRandom(row, column);
PrintMatrix(matrix);

if (rowSearch >= row || columnSearch >= column)
{
    Console.WriteLine($"There is no element with index [{rowSearch},{columnSearch}] in the given array");
}
else
{
    int val = matrix[rowSearch,columnSearch];
    Console.WriteLine($"There is an element {val} with index [{rowSearch},{columnSearch}] in the given array");
}


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int row = new Random().Next(1,20);
int column = new Random().Next(1,20);
int[,] FillMatrixWithRandom(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-100, 101);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
}
int[,] matrix = FillMatrixWithRandom(row, column);
PrintMatrix(matrix);

Console.WriteLine($"The arithmetic mean of column is:");
for (int j = 0; j < matrix.GetLength(1); j++)
{
    double sumCol = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sumCol += matrix[i,j];
    }
    Console.WriteLine($"col {j+1} = {Math.Round(sumCol / matrix.GetLength(0), 2)}");
}


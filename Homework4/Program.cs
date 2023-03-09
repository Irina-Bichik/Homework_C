// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Write("Input a number A: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number B: ");
int number2 = Convert.ToInt32(Console.ReadLine());

  if (number2 < 0)
    {
        Console.WriteLine($"The number {number2} is not natural");
    }
    
int Exponentiation (int numA, int numB)
{ 
int exp = 1;
    for (int i = 0; i < numB; i++)
    {
        exp *= numA;
    }
    return exp;
}

int result = Exponentiation (number1, number2);
Console.Write($"The number {number1} to the power of {number2} is {result}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigits (int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}
Console.WriteLine ($"The sum of the digits in the number {number} is {SumDigits (number)}.");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] FillArray(int size, int start, int finish)
{
    int[] arr = new int[size];
    Random rnd = new Random();  
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(start, finish + 1);
    }
    return arr;
}

Console.Write("Input the number of array elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the initial value: ");
int init = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the final value: ");
int final = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(size, init, final);
Console.WriteLine($"[{string.Join(", ", array)}]");


﻿// 1. Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее

Console.Write("Input a first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine($"max number is {number1} and min number is {number2}");
}
else
{
    Console.WriteLine($"max number is {number2} and min number is {number1}");
}


// 2. Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

Console.Write("Input a first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int Max (int number1, int number2, int number3)
{
    int max = number1;
    if (number2 > max) max = number2;
    if (number3 > max) max = number3;
    return max;
}
int max = Max (number1, number2, number3);
// Console.Write("max number is ");
// Console.WriteLine(max);

Console.WriteLine($"max number is {max}");


// 3. Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка)

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number %2 == 0)
{
     Console.WriteLine($"{number} is an even number");
}
else
{
    Console.WriteLine($"{number} is an odd number");
}

// 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = 2;

while (current <= number)
{
    Console.Write(current + " ");
    current+=2;
}


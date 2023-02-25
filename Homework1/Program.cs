// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее

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


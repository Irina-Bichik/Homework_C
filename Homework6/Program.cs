// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Input amount of numbers: ");
int N = Convert.ToInt32(Console.ReadLine());

int current = 1;
int count = 0;

while (current <= N) 
{
    Console.WriteLine("Input number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0) count ++;
    current ++;
}

Console.WriteLine($"Amount of positive numbers is {count}");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Input a value b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a value k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a value b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a value k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1)/(k1 - k2);
double y = k2 * x + b2;

if(k1 == k2 && b1 == b2) Console.WriteLine("These lines are coincident");
if(k1 == k2 && b1 != b2) Console.WriteLine("These lines are parallel");
if(k1 != k2) Console.WriteLine($"Two straight lines will intersect at a point with coordinates X: {x}, Y: {y}");






// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void PrintNumber(int n, int count)
{
    if(count > n)
    {
        return;
    }
    PrintNumber(n, count + 1);
    System.Console.Write(count + " ");
}

System.Console.Write("Input the number N: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
PrintNumber(number, count);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumberFromMToN(int m, int n)
{
    if(m > n)
    {
        return 0;
    }
    return m + SumNumberFromMToN(++m, n);
}

System.Console.Write("Input the number M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input the number N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
SumNumberFromMToN(numberM, numberN);
Console.Write(SumNumberFromMToN(numberM, numberN));


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AckermanFunction (int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AckermanFunction(m - 1, 1);
    if (m > 0 && n > 0) return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
return AckermanFunction(m, n);
}

System.Console.Write("Input the number m: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input the number n: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Ackerman function for numbers A({number1},{number2}) = {AckermanFunction(number1, number2)}");
//1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Input a three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int SecondDigit(int digit)
{
    int units = digit / 10;
    if (digit > 99 && digit < 1000)
    {
        return units % 10;
    }
    else
    {
        return -1;
    }       
}

int result = SecondDigit(number);
if (result < 0)
{
    Console.Write("You entered a non-three-digit number");
}
else
 {
    Console.WriteLine($"The second digit is {result}");
}

//2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int ThirdDigit (int givenNumber)
{
    while (givenNumber > 999 )
    {
      givenNumber /= 10;
    }
    return givenNumber % 10;
}

int result = ThirdDigit (number);
if (number >= 100)
{
    Console.WriteLine($"The third digit of a given number is {result}");
}
else
{
    Console.WriteLine("There is no third digit");
}

//3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Enter a number from 1 to 7 indicating the day of the week (where 1 is Monday, 7 is Sunday): ");
int number = Convert.ToInt32(Console.ReadLine());

bool isDay (int weekDay)
{
    if (weekDay > 0 && weekDay <= 7)
    {
    return true;
    }
    Console.WriteLine("You have entered incorrect data");
    return false; 
    
}

bool isWeekend (int NumDay)
{
    if (NumDay == 6 || NumDay == 7)
    {
        // Console.WriteLine("Today is a day off");
        return true;
    }
        // Console.WriteLine("Today is not a day off");
        return false; 
    
}

if (isDay(number))
{
    if (isWeekend (number))
    {
        Console.WriteLine("Today is a day off");
    }
    else
    {
        Console.WriteLine("Today is not a day off");
    }
}




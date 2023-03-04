// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Write("input a five-digit number ");
string number = Console.ReadLine();

bool isPalindrome(string newnumber)
{
    for (int index = 0; index < newnumber.Length; index++)
    {
       if (newnumber [index] < '0' || newnumber [index] > '9')
        {
            Console.WriteLine("It is not a number");
            return false;
        }      
    }
        
    if (newnumber.Length !=5)
    {
        Console.WriteLine("You entered not a five-digit number");
        return false;
    }
    else 
    {
        if (newnumber[0] == newnumber[4] && newnumber[1] == newnumber[3])
        {
            Console.WriteLine($"{newnumber} is Palindrome");
            return true;
        }
        else
        {
            Console.WriteLine($"{newnumber} is not Palindrome");
            return false;
        }
    }
} 
 isPalindrome(number);

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance3D(double x1, double y1, double z1, double x2, double y2, double z2)
{
double res = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
return Math.Round(res, 2);
}

Console.Write("Введите координату по Х для первой точки ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по У для первой точки ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по Z для первой точки ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по Х для второй точки ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по Y для второй точки ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по Z для второй точки ");
double z2 = Convert.ToDouble(Console.ReadLine());

double distance = Distance3D(x1, y1, z1, x2, y2, z2);
System.Console.WriteLine($"Расстояние между точками = {distance}");

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= number; i++)
{
Console.Write($"{Math.Pow(i, 3)} ");
}
if (number <= 0)
{
Console.WriteLine("input other number");
}



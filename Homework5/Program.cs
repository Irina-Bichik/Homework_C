// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] FillArrayWhithRandomNumber(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100,1000);
    }
    return arr;
}

Console.Write("Input the length of the array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWhithRandomNumber(size);
Console.Write("Your random array: ");
Console.WriteLine($"[{string.Join(", ", array)}]");

int count = 0;
for(int i = 0; i < array.Length; i++)
{
if(array[i] % 2 == 0)
{
count++;
}
}
Console.WriteLine($"The number of even numbers in the array is {count}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArrayWhithRandomNumber(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-10,11);
    }
    return arr;
}

Console.Write("Input the length of the array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWhithRandomNumber(size);
Console.Write("Your random array: ");
Console.WriteLine($"[{string.Join(", ", array)}]");

int sumOddPositions = 0;

for(int i = 1; i < array.Length; i+=2)
{       
    sumOddPositions+= array[i];
}
Console.WriteLine($"The sum of the elements in odd positions is {sumOddPositions}");

// Задача 38: Задайте массив вещественных чисел(тип double). Найдите разницу между максимальным и минимальным элементов массива.
// [3,1; 7,2; 22,3; 2,4; 78,5] -> 76,1

void FillArrayWhithRandomNumber(double[] number)
{
    for(int i = 0; i < number.Length; i++)
        {
            number[i] = Convert.ToDouble(new Random().Next(100,1000))/100; 
        }
}

Console.Write("Input the length of the array: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double [size];
FillArrayWhithRandomNumber(array);
Console.Write("Your random array: ");
Console.WriteLine($"[{string.Join(", ", array)}]");

double min = array[0];
double max = array[1];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        {
            max = array[i];
        }
    if (array[i] < min)
        {
            min = array[i];
        }
}

Console.WriteLine($"The maximum element of the array is {max}. The minimum element of the array is {min}.");
Console.WriteLine($"The difference between the maximum array element {max} and minimum array element {min} is {max - min}.");


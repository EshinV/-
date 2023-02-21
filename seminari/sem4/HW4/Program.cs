// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("Задача 25");
Console.WriteLine("Введите число 1: ");
int num251 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int num252 = int.Parse(Console.ReadLine());
if (num251<1 && num252<1)
{
    Console.WriteLine("одно или оба числа 1: ");
}
else
{                                                          
    Console.WriteLine($"степень = {GetStep(num251,num252)}");
}
int GetStep (int A25, int B25)
{
    int Step=A25;
    for (int i = 1; i < B25; i++)
    {
        Step=Step*A25;
    }
    return Step;
    } 

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Задача № 27");
Console.WriteLine("Введите число: ");
int num27 = int.Parse(Console.ReadLine());

int Sum27 (int num27)
{
  int result27 = 0;
  for (; num27 > 0; num27 = num27/10)
  {
   result27 = result27 + num27%10;
  }
  return result27;
}

Console.WriteLine($"Сумма цифр {Sum27(num27)}");



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index<length)
    {
       collection[index] = new Random().Next(1,10);
       index++;
    }
}
void PrintArray(int[] col)
{
    int count=col.Length;
    int position = 0;
    while (position<count)
    {
        Console.Write(col[position]);
        position++;
    }
}
Console.WriteLine("Задача № 29");
Console.WriteLine("Введите длинну массива: ");
int num29 = int.Parse(Console.ReadLine());
int [] array = new int[num29];

FillArray(array);
Console.Write("Массив:");
PrintArray(array);

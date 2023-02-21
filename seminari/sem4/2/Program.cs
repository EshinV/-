// Задача 26: Напишите программу, которая принимает на вход число и выдает количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

System.Console.WriteLine("Введите число: ");
int Number = int.Parse(Console.ReadLine());

if (Number<0)
{
    System.Console.WriteLine("Число меньше 0");
}
else
{
    System.Console.WriteLine($"CountNumbers={CountNumbers(Number)}");
}


int CountNumbers(int Num)
{
    int count=0;
    for (;Num>0;count++)
    {
        Num=Num/10;
    }
    return count;
}

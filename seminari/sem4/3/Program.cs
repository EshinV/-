// Решение в группах задач:
// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число: ");
int numA = int.Parse(Console.ReadLine());

if (numA<1)
{
    Console.WriteLine("Число А меньше 1: ");
}
else
{                                                          
  int result = GetSum(numA);
    Console.WriteLine($"произведение = {result}");
    Console.WriteLine($"произведение = {GetSum(numA)}");
}

int GetSum (int number)
{
    int com = 1;
    for (int i = 1; i <= number; i++)
    {
        com=i*com;//numsum=numsum+i
    }
    return com;
   
} 
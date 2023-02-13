//Напишите программу, котоорая принимает на вход число (А) и выдаёт сцмму чисел от 1 до А

Console.WriteLine("Введите первое число А: ");
int numA = int.Parse(Console.ReadLine());
if (numA<1)
{
    Console.WriteLine("Число А меньше 1: ");
}
else
{
    int numsum = 0;
    for (int i = 1; i <= numA; i++)
    {
   numsum += i;//numsum=numsum+i
    }
    Console.WriteLine($"сумма = {numsum}");
}


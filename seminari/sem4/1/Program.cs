//Напишите программу, котоорая принимает на вход число (А) и выдаёт сцмму чисел от 1 до А

// Console.WriteLine("Введите первое число А: ");
// int numA = int.Parse(Console.ReadLine());

// if (numA<1)
// {
//     Console.WriteLine("Число А меньше 1: ");
// }
// else
// {                                                            //БЕЗ МЕТОДА
//     int sum = 0;
//     for (int i = 1; i <= numA; i++)
//     {
//         sum += i;//numsum=numsum+i
//     }
//     Console.WriteLine($"сумма = {sum}");
// }

Console.WriteLine("Введите первое число А: ");
int numA = int.Parse(Console.ReadLine());

if (numA<1)
{
    Console.WriteLine("Число А меньше 1: ");
}
else
{                                                          
  int result = GetSum(numA);
    Console.WriteLine($"сумма = {result}");
    Console.WriteLine($"сумма = {GetSum(numA)}");
}

int GetSum (int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum += i;//numsum=numsum+i
    }
    return sum;
   
} 
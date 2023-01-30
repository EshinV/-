// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
Console.WriteLine("Введите первое число: ");
int FirstTaskNumber1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int FirstTaskNumber2 = Convert.ToInt32(Console.ReadLine());

if (FirstTaskNumber1 > FirstTaskNumber2) Console.WriteLine(FirstTaskNumber1);
else  Console.WriteLine(FirstTaskNumber2);


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.WriteLine("Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
Console.WriteLine("Введите первое число: ");
int SecondTaskNumber1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int SecondTaskNumber2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int SecondTaskNumber3 = Convert.ToInt32(Console.ReadLine());

int SecMaxNum = 0;

if (SecondTaskNumber1 > SecondTaskNumber2) SecMaxNum = SecondTaskNumber1;
else SecMaxNum = SecondTaskNumber2;
if (SecMaxNum > SecondTaskNumber3) Console.WriteLine(SecMaxNum);
else Console.WriteLine(SecondTaskNumber3) ;


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)");
Console.WriteLine("Введите число: ");
int ThirdTaskNumber1 = Convert.ToInt32(Console.ReadLine());
if (ThirdTaskNumber1%2==0) Console.WriteLine("чётное");
else Console.WriteLine("не чётное");



// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.WriteLine("Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N");
Console.WriteLine("Введите число: ");
int FourthTaskNumber1 = Convert.ToInt32(Console.ReadLine());
int cycle = 1;
while (FourthTaskNumber1 > cycle) 
{
    Console.WriteLine (cycle+1);
    cycle+=2;
}

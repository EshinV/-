﻿// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 % 7 == 0 && num1 % 7 == 0)  //$$ - аргумиент И, || - Или
{
    Console.WriteLine("да");
}

else
{
    Console.WriteLine("нет");
}



// int ost = num1 % (7*23);

// if (ost == 0)
// {
//     Console.WriteLine("да");
// }
// else
// {
//       Console.WriteLine("нет");
// }
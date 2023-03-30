// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// System.Console.WriteLine("Задача 41.");
// System.Console.WriteLine("Введите целые числа через пробел:");

// int[] mas41 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

// int CountPositiveNumbers(int[] array)  
// {
//   int count = 0;
//   for (int i = 0; i < array.Length; i++)
//   {
//     if (array[i] > 0)
//       count++;
//   }
//   return count;
// }

// System.Console.WriteLine($"Пользователь ввел {CountPositiveNumbers(mas41)} чисел больше 0");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

System.Console.Write("Задача 43.");
     
System.Console.Write("Задайте значение b1: ");
double b1 = int.Parse(Console.ReadLine());

System.Console.Write("Задайте значение b2: ");
double b2 = int.Parse(Console.ReadLine());

System.Console.Write("Задайте значение k1: ");
double k1 = int.Parse(Console.ReadLine());

System.Console.Write("Задайте значение k2: ");
double k2 = int.Parse(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k2 * x + b2;

if ((y != k1 * x + b1) || (k1 - k2 == 0)) System.Console.WriteLine("Решений нет!");
  else
  {
    System.Console.WriteLine($"Координаты пересечения двух прямых, x, y: ({x}); ({y})");
  }

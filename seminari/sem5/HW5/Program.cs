// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] GetArray(int size, int minValue, int maxValue)
 {
     int[] res = new int[size]; //new int - создание массива размером size

     for (int i = 0; i < size; i++)
     {
        res[i] = new Random().Next(minValue, maxValue + 1); //+1 так последнее значение не учитывается
     }
    return res;
 }

Console.WriteLine("Задача 34");
int[] array34 = GetArray(10, 100, 999); // первая цифра количесвво символов, мин значение, мах значение
Console.WriteLine(String.Join(" ", array34));
Console.WriteLine($"Количество четных элементов - {Count34(array34)}");


int Count34(int[] array342)
{
   int count342 =0;
   foreach (int a34  in array342)  
   {
      if (a34%2 == 0) count342++; 
    
   }
   return count342;
}


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях. (0 это чётный)
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Задача 36");
int[] array36 = GetArray(4, 0, 10); // первая цифра количесвво символов, мин значение, мах значение
Console.WriteLine(String.Join(" ", array36));
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях - {Sum36(array36)}");


int Sum36(int[] array362)
{
   int sum362 =  0;
   for (int i = 1; i < array362.Length; i+=2)  
   {
      if (i%2 == 1) sum362=sum362+array362[i]; 
   }
   return sum362;
}


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] GetArrayDoub(int size, int minValue, int maxValue)
 {
     double[] res = new double[size]; 
   Random rand = new Random();
     for (int i = 0; i < size; i++)
     {
        res[i] = rand.Next(minValue, maxValue)+ rand.NextDouble(); //+1 так последнее значение не учитывается
     }
    return res;
 }

double Dif(double[] ArrayDif)  // Метод для нахождения разницы между максимальным и минимальным значениями в массиве

{
    double Min = ArrayDif[0];
    double Max = ArrayDif[0];

    for (int i = 0; i < ArrayDif.Length; i++)
    {
        if (ArrayDif[i] < Min) Min = ArrayDif[i];
        if (ArrayDif[i] > Max) Max = ArrayDif[i];
    }
    double dif38 = Max - Min;
    return dif38;
}

Console.WriteLine("Задача 38");
double[] array38 = GetArrayDoub(5, 0, 3); // первая цифра количесвво символов, мин значение, мах значение
Console.WriteLine(String.Join(" ", array38));
Console.WriteLine($"Разница разницы между максимальным и минимальным значениями - {Dif(array38)}");
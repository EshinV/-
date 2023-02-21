﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
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
int[] array34 = GetArray(5, 100, 999); // первая цифра количесвво символов, мин значение, мах значение
Console.WriteLine(String.Join(" ", array34));

int SumDub34 (int SumNum34);
{
   SumNum34 == 0
}


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях. (0 это чётный)
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
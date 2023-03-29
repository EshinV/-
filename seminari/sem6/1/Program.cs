// 1:09:13
// /
// Продолжительность 2:25:10

// Задача 39:
// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый на последнем и т.д.)
// [1 2 3 4 5] --> [5 4 3 2 1]
// [6 7 3 6] --> [6 3 7 6]

int SetNumber(string numberName)
{
    Console.WriteLine($"Введите {numberName}:");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


int[] GetArray(int size, int minValue, int maxValue)
 {
     int[] res = new int[size]; //new int - создание массива размером size

     for (int i = 0; i < size; i++)
     {
        res[i] = new Random().Next(minValue, maxValue + 1); //+1 так последнее значение не учитывается
     }
    return res;
 }


int ArraySize = SetNumber ("размер массива");
int minValue = SetNumber ("минимальное значение массива");
int maxValue = SetNumber ("максимальное значение массива");
int Result = 0;

int [] numbers = GetArray (ArraySize, minValue, maxValue);
Console.WriteLine(String.Join(" ", numbers));
Console.WriteLine();


int [] ReversArray (int [] set)
{
    
    for (int i = 0; i < set.Length/2; i++)
    {
        int temp = set [i];
        set [i] = set[set.Length - 1 - i];
        set[set.Length - 1 - i] = temp;
     }
     return set;
}

Console.WriteLine(String.Join(" ", ReversArray (numbers)));
Console.WriteLine();
// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
Console.WriteLine("Задача 32");
int[] array32 = GetArray(4, -9, 9); // первая цифра количесвво размеров, мин значение, мах значение
int[] GetArray(int size, int minValue, int maxValue)
 {
     int[] res = new int[size]; //new int - создание массива размером size

     for (int i = 0; i < size; i++)
     {
        res[i] = new Random().Next(minValue, maxValue + 1); //+1 так последнее значение не учитывается
     }
    return res;
 }

Console.WriteLine(String.Join(" ", array32)); // обеденяет массив в одну строку и разделяет побелом

for (int i = 0; i < array32.Length; i++)
{
    array32[i]=array32[i]*(-1);
    Console.Write($" {array32[i]}");
}



// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.WriteLine("Задача 33");
int[] array33 = GetArray(4, -9, 9);
Console.WriteLine(String.Join(" ", array33));
Console.WriteLine("Введите число: ");
int num33 = int.Parse(Console.ReadLine());



bool Yes = false;
foreach (int el in array33)   
{
 
    if (Math.Abs(el)==Math.Abs(num33))
    Yes = true;
}
if (Yes) Console.WriteLine ("da");
else Console.WriteLine ("no");



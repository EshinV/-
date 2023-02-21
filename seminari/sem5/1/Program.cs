// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна
// -20.
int[] array = GetArray(12, -9, 9); // первая цифра количесвво размеров, мин значение, мах значение
Console.WriteLine(String.Join(" ", array)); // обеденяет массив в одну строку и разделяет побелом

int positiveSum = 0;
int negativeSum = 0;

foreach (int el in array)   // это цикл который берёт каждый элемент массива и записывает его в созданный внутри элемент   //если написать var то присвается то значение которые передаётся
{
   positiveSum += el > 0 ? el : 0; //если этот элемент больше 0 возвращаем число, иначе возвращаем 0
   negativeSum += el < 0 ? el : 0; // как и выше только наоборот
}
/*
Другая форма записи foreach 
for (int i = -; i<array.Lenght; i++)  
{
   positiveSum += el > 0 ? el : 0;
   negativeSum += el < 0 ? el : 0;
*/
 Console.WriteLine($"Positive sum = {positiveSum}, negative sum = {negativeSum} ");

 int[] GetArray(int size, int minValue, int maxValue)
 {
     int[] res = new int[size]; //new int - создание массива размером size

     for (int i = 0; i < size; i++)
     {
        res[i] = new Random().Next(minValue, maxValue + 1); //+1 так последнее значение не учитывается
     }
    return res;
 }


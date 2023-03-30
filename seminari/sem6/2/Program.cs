
// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// *Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.*

// Console.WriteLine("Задача 40:");
// int SetNumber(string numberName)
// {
//     Console.WriteLine($"Введите {numberName}:");
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }



// int a40 = SetNumber ("сторону А");
// int b40 = SetNumber ("сторону B");
// int c40 = SetNumber ("сторону C");

// bool IsTriangle(int a,int b,int c)  // - способ что предложил Габиль
// {
// return (((a+b)>c40)&&((a+c)>b)&&((b+c)>a));
// }

// if (IsTriangle(a40,b40,c40) )
// {
//     Console.WriteLine("треугольник");
// }
// else
// {
//     Console.WriteLine("не треугольник");
// }

// if ((a40 > (b40 + c40) ) || (b40 > (a40 + c40) )  || (c40 > (b40 + a40)))  - // мой способ
// {
//     Console.WriteLine("не треугольник");
// }
// else
// {
//     Console.WriteLine("треугольник");
// }




// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// 45 -> 101101
// 3 -> 11
// 2-> 10

Console.WriteLine("Задача 42:");
Console.WriteLine("Введите число ");
int a42 = Convert.ToInt32(Console.ReadLine());


int [] Numbers42(int num42)
{
    int size42 = 32;
    int [] result42 = new int [size42];
    for (int i = 0; i < size42; i++)
    {
        result42[i] = num42 % 2;
        num42/=2;
    }
    return result42;
}

int []  Bin24 = (Numbers42(a42));
Array.Reverse(Bin24);

Console.WriteLine("Полученный массив = " + String.Join(" ", Bin24));

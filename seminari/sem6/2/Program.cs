
// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// *Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.*


int SetNumber(string numberName)
{
    Console.WriteLine($"Введите {numberName}:");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int a40 = SetNumber ("сторону А");
int b40 = SetNumber ("сторону B");
int c40 = SetNumber ("сторону C");

bool IsTriangle(int a,int b,int c)  // - способ что предложил Габиль
{
return (((a+b)>c40)&&((a+c)>b)&&((b+c)>a));
}

if (IsTriangle(a40,b40,c40) )
{
    Console.WriteLine("треугольник");
}
else
{
    Console.WriteLine("не треугольник");
}

// if ((a40 > (b40 + c40) ) || (b40 > (a40 + c40) )  || (c40 > (b40 + a40)))  - // мой способ
// {
//     Console.WriteLine("не треугольник");
// }
// else
// {
//     Console.WriteLine("треугольник");
// }



остановился на 1:52:12 



// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// 45 -> 101101
// 3 -> 11
// 2-> 10
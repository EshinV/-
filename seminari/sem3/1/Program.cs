// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

System.Console.WriteLine("Введите X: ");
int numX = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите Y: ");
int numY = int.Parse(Console.ReadLine());

if (numX>0 && numY>0)
{
    System.Console.WriteLine ("1я четверть плоскости");
}
else if (numX<0 && numY>0)
{
    System.Console.WriteLine ("2я четверть плоскости");
}
else if (numX<0 && numY<0)
{
    System.Console.WriteLine ("3я четверть плоскости");
}
else if (numX>0 && numY<0)
{
    System.Console.WriteLine ("4я четверть плоскости");
} 



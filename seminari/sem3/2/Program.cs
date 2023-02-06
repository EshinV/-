// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

System.Console.WriteLine("Введите номер четверти (1-4): ");
int num1 = int.Parse(Console.ReadLine());

// while (true)                                                 //Цикл проверки именнно ужных чисел
// {
// System.Console.WriteLine("Enter quarter number ");
// quarter = int.Parse(Console.ReadLine());
// if (quarter >=1 && quarter <= 4)
// {
// break;
// }
// }

if (num1==1)
{
    System.Console.WriteLine ("x>0, y>0");
}
else if (num1==2)
{
    System.Console.WriteLine ("x<0, y>0");
}
else if (num1==3)
{
    System.Console.WriteLine ("x<0, y<0");
}
else if (num1==4)
{
    System.Console.WriteLine ("x>0, y<0");
}
else 
{
    System.Console.WriteLine ("неверное число");
}
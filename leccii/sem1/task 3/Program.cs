// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

// Console.Write("Введите число от 1 до 7: ");
// string day = Console.ReadLine();





Console.WriteLine("Введите число от 1 до 7: ");
string? answer = Console.ReadLine();
int day = Convert.ToInt32(answer);

if (day > 7 || day < 1)
{
    Console.WriteLine ("Chislo neverno!");
}
if(day == 1) Console.WriteLine("пн");
if(day == 2) Console.WriteLine("вт");
if(day == 3) Console.WriteLine("ср");
if(day == 4) Console.WriteLine("чт");
if(day == 5) Console.WriteLine("пт");
if(day == 6) Console.WriteLine("сб");
if(day == 7) Console.WriteLine("вс");








// else
// {
//     Console.Write("непонятно");
// //     //Console.WriteLine(day);
//  }


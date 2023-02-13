// Задача 10: Напишите программу, 
// которая принимает на вход трёхзначное число и на 
// выходе показывает вторую цифру этого числа

Console.WriteLine("Задача №10");
Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ( 99<number && number<1000)
{
    int number1 = number/100; //другой варинат запсиси :int number1 = (number/10)%10; 
    int number2 = (number - number1*100)/10;
    Console.WriteLine(number2);
} 
else Console.WriteLine("Число не трёхзначное");



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Задача №13");
Console.WriteLine("Введите число больше 99: ");
int Number13 = Convert.ToInt32(Console.ReadLine());
if (Number13 <100)
{
    Console.WriteLine("Третьей цифры нет!");
}
while (Number13>999)
{
    Number13 = Number13 / 10;
}
    Console.WriteLine($"Третья цифра - {Number13%10}");



// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

Console.WriteLine("Задача №15");
Console.WriteLine("Введите число означающее день недели: ");
int answer = Convert.ToInt32(Console.ReadLine()); 

if (answer > 7 || answer < 1) Console.WriteLine ("Число не верное");
if(answer == 1 || answer == 2|| answer == 3 || answer == 4 || answer == 5) Console.WriteLine("Не выходной");
if(answer == 6 || answer == 7) Console.WriteLine("Выходной");
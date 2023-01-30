// Напишите программу, которая выводит случайное трехзначное число и 
// удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100,1000);

int number1 = number/100; 
int number2 = (number - number1*100)/10;
int number3 = number%10;



Console.WriteLine(number);
Console.WriteLine(number1);
Console.WriteLine(number2);
Console.WriteLine(number3);

// Console.Write($"{number1}{number3}"); Колхозный вариант

int sum = number1*10+number3;
Console.WriteLine(sum);
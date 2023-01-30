// Напишите программу, которая на вход принимает 
// число и выдает его квадрат (число умноженное
//  на само себя).

//  Например:
// 4-> 16
// - 3-> 9
// - 7-> 49

Console.WriteLine("Ввидите число");
//int number = Convert.ToInt32(Console.ReadLine());
string? answer = Console.ReadLine();
int number = Convert.ToInt32(answer);

// Console.WriteLine(number * number); - 1й способ

int sqr = number * number; //2й способ
Console.WriteLine(sqr);
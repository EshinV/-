// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.

System.Console.WriteLine("Введите число>1: ");
int num1 = int.Parse(Console.ReadLine());

int num2 = 1;
while (num1>=num2)
{
    System.Console.Write(num2*num2+ " ");
    num2=num2+1;
}


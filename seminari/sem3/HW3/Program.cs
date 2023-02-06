// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Задача №19");
Console.WriteLine("Введите пятизначно число : ");
int num191 = Convert.ToInt32(Console.ReadLine());

if ( 9999<num191 && num191<100000)
{    int number1 = num191 /10000; 
    int number2 = (num191/1000-number1*10);  
    int number3 = (num191/100-number2*10-number1*100);  
    int number4 = (num191/10-number3*10-number2*100-number1*1000); 
    int number5 = num191%10; 
        if (num191 == number1+number2*10+number3*100+number4*1000+number5*10000) Console.WriteLine("Палиндром");      
        else  Console.WriteLine("Не палиндромом");
}
else Console.WriteLine("Число не пятизначно");

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Задача №21");
System.Console.WriteLine("Введите X1: ");
int numX1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите Y1: ");
int numY1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите Z1: ");
int numZ1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите X2: ");
int numX2 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите Y2: ");
int numY2 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите Z2: ");
int numZ2 = int.Parse(Console.ReadLine());

int sumsqr=((numX2-numX1)*(numX2-numX1)+(numY2-numY1)*(numY2-numY1)+(numZ2-numZ1)*(numZ2-numZ1));
double stepen= 0.5;

double result = Math.Pow(sumsqr,stepen);  //ьог написать Math.Sqrt()

System.Console.WriteLine(result);


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Задача №23");
System.Console.WriteLine("Введите число которое больше 1: ");
int num231 = int.Parse(Console.ReadLine());

int num232 = 1;
while (num231>=num232)
{
    System.Console.Write(num232*num232*num232 + " ");
    num232=num232+1;
}

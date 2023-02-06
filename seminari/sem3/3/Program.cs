// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

System.Console.WriteLine("Введите X1: ");
int numX1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите Y1: ");
int numY1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите X2: ");
int numX2 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите Y2: ");
int numY2 = int.Parse(Console.ReadLine());

int sumsqr=((numX2-numX1)*(numX2-numX1)+(numY2-numY1)*(numY2-numY1));
double stepen= 0.5;

double result = Math.Pow(sumsqr,stepen);  //ьог написать Math.Sqrt()

System.Console.WriteLine(result);
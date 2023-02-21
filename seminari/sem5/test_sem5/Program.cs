
//Метод ввода числа:

int SetNumber(string numberName)
{
    Console.WriteLine($"Enter number {numberName}:");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int TestNum =  SetNumber("test");
Console.WriteLine(TestNum);
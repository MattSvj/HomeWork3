//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
string? str = Console.ReadLine();
if (str == new string(str.Reverse().ToArray()))
Console.WriteLine("YES");
else
Console.WriteLine("NO");
*/
//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int z = Convert.ToInt32(Console.ReadLine());
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());
int x3 = x2 - x;
int y3 = y2 - y;
int z3 = z2 - z;
Console.WriteLine(Math.Sqrt(Math.Pow(x3, 2) + Math.Pow(y3, 2) + Math.Pow(z3, 2)));
*/
//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
while(i <= N)
{
    Console.WriteLine(Math.Pow(i, 3));
    i++;
}

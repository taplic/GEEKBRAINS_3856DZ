/*  Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int num = Math.Abs(number);
int preNumber = num;
int temp = 0;

while (num > 0)
{
  temp = temp * 10 + num % 10;
  num = num / 10;
}
if (preNumber == temp)
{
  Console.WriteLine("Это палиндром");
}
else if (preNumber != temp)
{
  Console.WriteLine("Это не палиндром");
}


/* Задача 21
 Напишите программу, которая принимает на вход координаты двух точек и
 находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/


Console.WriteLine("Введите координату X1 первой точки: ");
double numberX1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y1 первой точки: ");
double numberY1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Z1 первой точки: ");
double numberZ1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату X2 второй точки: ");
double numberX2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y2 второй точки: ");
double numberY2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Z2 второй точки: ");
double numberZ2 = double.Parse(Console.ReadLine());


double resultX = numberX1 - numberX2;
double resultY = numberY1 - numberY2;
double resultZ = numberZ1 - numberZ2;


double resultSqr = Math.Sqrt(Math.Pow(resultX, 2) + Math.Pow(resultY, 2) + Math.Pow(resultZ, 2));
Console.WriteLine($"Расстояние между точками {resultSqr}");




/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/


Console.WriteLine("Введите число: ");
int numberN = int.Parse(Console.ReadLine());
int ind = 1;
while (ind <= numberN)
{
  Console.Write($"{ind * ind * ind} ");
  ind++;
}











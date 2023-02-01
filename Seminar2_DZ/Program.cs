/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и
на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
  int result = (number / 10) % 10;
  Console.WriteLine($"Вторая цифра числа это: {result}");
}
else
{
  Console.WriteLine("Это не трехзначное число");
}

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
что третьей цифры нет.
645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
*/

Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA <= 99)
{
  Console.WriteLine("Третьей цифры в этом числе нет");
  return;
}
if (numberA > 99 && numberA <= 999)
{
  numberA = numberA % 10;
}
while (numberA > 999)
{
  if (numberA > 999) numberA /= 10;
}
Console.WriteLine($"Третья цифра числа это: {numberA % 10}");


/*
Задача 15:
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите число: ");
int numberDayOfWeek = Convert.ToInt32(Console.ReadLine());

if (numberDayOfWeek < 1 || numberDayOfWeek > 7)
{
  Console.WriteLine("Нет такого дня недели");
  return;
}
if (numberDayOfWeek == 6 || numberDayOfWeek == 7)
{
  Console.WriteLine("Это выходной");
}
else
{
  Console.WriteLine("Это рабочий день");
}



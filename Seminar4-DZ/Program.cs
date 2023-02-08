/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
#nullable disable

Console.WriteLine("Введите число A");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B");
int numberB = int.Parse(Console.ReadLine());
int NaturalDegree(int number, int degree)
{
  int result = 1;
  for (int i = 1; i <= degree; i++)
  {
    result = result * number;
  }
  return result;
}
Console.WriteLine($"A в степени B равно: {NaturalDegree(numberA, numberB)}");


/* Задача 27: Напишите программу, которая принимает на вход число
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
#nullable disable

Console.WriteLine("Введите число");
int number1 = int.Parse(Console.ReadLine());

int Summ(int number)
{
  int result = 0;
  for (; number > 0; number /= 10)
  {
    result = result + number % 10;
  }
  return result;
}
Console.WriteLine($"Сумма цифр в числе равна {Summ(number1)}");


/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

#nullable disable

int[] array = new int[8];

void Fill(int[] numbers)
{
  int length = numbers.Length;
  for (int i = 0; i < length; i++)
  {
    numbers[i] = new Random().Next(1, 50);
  }
  Console.WriteLine();
}

void Print(int[] col)
{
  int num = col.Length;
  for (int count = 0; count < num; count++)
  {
    Console.Write(col[count] + " ");
  }
}
Fill(array);
Print(array);











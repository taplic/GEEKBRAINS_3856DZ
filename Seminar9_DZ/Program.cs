/* Задача 64.а: Задайте значение N. Напишите программу,
которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
Console.WriteLine($"Задача № 64.a  рекурсивно");

int numA = SetNumber("введите число N ");
int numB = 1;
OutputNaturalNumbersIntervalRec(numA, numB);
Console.WriteLine();

void OutputNaturalNumbersIntervalRec(int n, int m)
{
  if (m > n)
  {
    return;
  }
  else
  {
    OutputNaturalNumbersIntervalRec(n, m + 1);
    Console.Write(m + " ");
  }
}

int SetNumber(string numberName)
{
  Console.WriteLine($" {numberName}: ");
  int num = Convert.ToInt32(Console.ReadLine());
  return num;
}

/* Задача 64.б Задайте значения M и N. Напишите программу,
которая выведет все натуральные числа в промежутке от  M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 6, 7, 8"
*/
Console.WriteLine($"Задача № 64.b  итеративно");

int numN = SetNumber("введите число N ");
int numM = SetNumber("введите число M ");
OutputNaturalNumbersIntervalRec2(numN, numM);
Console.WriteLine();

void OutputNaturalNumbersIntervalRec2(int n, int m)
{
  if (m > n)
    for (int i = n; i <= m; i++)
    {
      Console.Write($" {i}");
    }
  else
    for (int i = m; i <= n; i++)
    {
      Console.Write($" {i}");
    }
}

/* Задача 66: Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
Console.WriteLine($"Задача № 66.a  рекурсивно");

int numberA = SetNumber("введите число N ");
int numberB = SetNumber("введите число M ");
Console.WriteLine($"Сумма в этом промежутке натуральных чисел = {SumNaturalInterval(numberA, numberB)}");
Console.WriteLine();

int SumNaturalInterval(int m, int n)
{
  if (m == n) return m;
  else if (m < n) return n + SumNaturalInterval(m, n - 1);
  else return n + SumNaturalInterval(m, n + 1);
}

Console.WriteLine($"Задача № 66.b  итеративно");

int num1 = SetNumber("введите число N ");
int num2 = SetNumber("введите число M ");
SumNaturalInterval2(num1, num2);
Console.WriteLine();

void SumNaturalInterval2(int n, int m)
{
  int sum = 0;
  if (m < n)
    for (int i = m; i <= n; i++)
    {
      sum += i;
    }
  else
    for (int i = n; i <= m; i++)
    {
      sum += i;
    }
  Console.WriteLine($"Сумма в этом промежутке натуральных чисел = {sum} ");
}

/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

Console.WriteLine($"Задача № 68  рекурсивно");

int number1 = SetNumber("Введите положительное число m ");
int number2 = SetNumber("Введите положительное число n ");
int functionAkkerman = Ack(number1, number2);
Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Ack(int m, int n)
{
  if (m == 0)
  {
    return n + 1;
  }
  else if (n == 0 && m > 0)
  {
    return Ack(m - 1, 1);
  }
  else
  {
    return (Ack(m - 1, Ack(m, n - 1)));
  }
}















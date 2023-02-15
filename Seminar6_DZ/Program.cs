/* Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
Console.Write("Введите числа(через пробел): ");
int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Print(numbers);
Console.WriteLine();
Console.WriteLine($"Кол-во элементов > 0: {CountNumbers(numbers)}");
int CountNumbers(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > 0)
    {
      count++;
    }
  }
  return count;
}
void Print(int[] col)// вывод данных массива на экран
{
  int num = col.Length;
  for (int count = 0; count < num; count++)
  {
    Console.Write(col[count] + " ");
  }
}
Console.WriteLine();

/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
 y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.WriteLine("введите число значения b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число значения k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число значения b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число значения k2");
double k2 = Convert.ToInt32(Console.ReadLine());
//Уравнение(решение по школьной программе):
//y = k1 * x + b1, y = k2 * x + b2
//k1 * x + b1 = k2 * x + b2
//(k1 - k2) * x = b2 - b1
//x = (b2 - b1) / (k1 - k2)
//y = k1 * x + b1

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
x = Math.Round(x, 3);
y = Math.Round(y, 3);

if (k1 != k2)
{
  Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
}
else if (k1 == k2 && b2 != b1)
{
  Console.WriteLine($"две прямые параллельны");
}
else
{
  Console.WriteLine($"две прямые совпадают");
}


/* Задача 44:выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5
--> 0 1 1 2 3
Если N = 3
--> 0 1 1
Если N = 7
--> 0 1 1 2 3 5 8
*/

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Fibonacci(number);
int Fibonacci(int n)
{
  if (n == 1) return 0;
  if (n == 2) return 1;
  else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
for (int i = 1; i <= number; i++)
{
  Console.WriteLine(Fibonacci(i));
}




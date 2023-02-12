/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
#nullable disable

int[] array = GetArray(8, 100, 1000);
Print(array);
int num = CountEven(array);

int[] GetArray(int size, int minValue, int maxValue)//для заполнения массива случайными числами
{
  int[] res = new int[size];
  for (int i = 0; i < size; i++)
  {
    res[i] = new Random().Next(minValue, maxValue + 1);
  }
  return res;
}

void Print(int[] col)// вывод данных массива на экран
{
  int num = col.Length;
  for (int count = 0; count < num; count++)
  {
    Console.Write(col[count] + " ");
  }
}

int CountEven(int[] array)// для исчисления количества четных чисел
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] % 2 == 0) count++;
  }
  return count;
}
Console.WriteLine($"количество чётных чисел в массиве = {num} ");
Console.WriteLine();


/* Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

#nullable disable

int[] Array = GetArray(8, -10, 100);
Console.WriteLine(String.Join(" ", Array));
int summ = SumOddPosition(Array);

int SumOddPosition(int[] array)//  для вычисления суммы элементов, стоящих на нечётных позициях
{
  int sum = 0;
  for (int i = 1; i < array.Length; i += 2)
    sum = sum + array[i];
  return sum;
}
Console.WriteLine($"сумма элементов, стоящих на нечётных позициях = {summ} ");
Console.WriteLine();




/* Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
#nullable disable

double[] numbers = RandomDouble(8, 1, 100);
Console.WriteLine();
PrintArray(numbers);
double difference = DifMaxMin(numbers);

double DifMaxMin(double[] array)//  для нахождения разницы между максимальным и минимальным значениями в массиве
{
  double max = array[0];
  double min = array[0];


  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
  }
  Console.WriteLine($"максимальное значение = {max}, минимальное значение = {min}");
  return max - min;
}


void PrintArray(double[] numbers)//  вывод данных массива вещественных чисел на экран
{
  for (int i = 0; i < numbers.Length; i++)
  {
    Console.Write(numbers[i] + " ");
  }
  Console.WriteLine();
}


double[] RandomDouble(int size, int minValue, int maxValue)  //  для заполнения массива случайными вещественными числами
{
  double[] res = new double[size];


  for (int i = 0; i < size; i++)
  {
    res[i] = Convert.ToDouble(new Random().Next(100, 1000) / 10.0);
  }
  return res;
}
Console.WriteLine($"разница между максимальным и минимальным значениями = {difference} ");








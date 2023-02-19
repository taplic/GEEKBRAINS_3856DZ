/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
Console.WriteLine($"Задача № 47");

int numRows = SetNumber("введите количество строк");
int numColumns = SetNumber("введите количество столбцов");
int numMaxValue = SetNumber("введите максимальное значение");
int numMinValue = SetNumber("введите минимальное значение");
var matrix = GetMatr(numRows, numColumns, numMinValue, numMaxValue);
PrintArray(matrix);
Console.WriteLine();

int SetNumber(string numberName)
{
  Console.WriteLine($" {numberName}: ");
  int num = Convert.ToInt32(Console.ReadLine());
  return num;
}

void PrintArray(double[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($" {matrix[i, j]} ");
    }
    Console.WriteLine();
  }
}

double[,] GetMatr(int rows, int columns, int min, int max)
{
  double[,] matrix = new double[rows, columns];
  Random rand = new Random();
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      matrix[i, j] = Math.Round((rand.Next(min, max + 1) + rand.NextDouble()), 2);
    }
  }
  return matrix;
}

/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание,
 что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
Console.WriteLine($" Задача № 50");

int[,] numbers = GetMatrix(3, 4, 1, 9);
FintPosition(numbers);
Console.WriteLine();
Print(numbers);
Console.WriteLine();

void Print(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($" {matrix[i, j]} ");
    }
    Console.WriteLine();
  }
}

int[,] GetMatrix(int rows, int columns, int min, int max)
{
  int[,] matrix = new int[rows, columns];
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      matrix[i, j] = new Random().Next(min, max + 1);
    }
  }
  return matrix;
}

void FintPosition(int[,] matrix)
{
  int i = SetNumber("введите индекс строки");// вызвала метод SetNumber из предыдущей задачи 
  int j = SetNumber("введите индекс столбца");
  if (i < numbers.GetLength(0) && j < numbers.GetLength(1))
  {
    Console.WriteLine($" На позиции индекса строки = {i} и столбца = {j} находится число = {numbers[i, j]} ");
  }
  else
  {
    Console.WriteLine($" -> такого элемента  нет");
  }
}

/* Задача 52. Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
Console.WriteLine($" Задача № 52");

int[,] array = GetMatrix(3, 4, 1, 9);
Console.WriteLine();
Print(array);
Console.WriteLine();
AvgNumbers(array);

void AvgNumbers(int[,] array)
{
  for (int j = 0; j < array.GetLength(1); j++)
  {
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
      sum += array[i, j];
    }
    double average = sum / array.GetLength(0);
    Console.WriteLine($"Среднее арифметическое  столбца =   {Math.Round(average, 2)} ");
  }
  Console.WriteLine();
}

/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
Console.WriteLine($" Задача № 62");

int[,] Array = FillArraySpiral(4, 4);
Console.WriteLine();
Print(Array);

int[,] FillArraySpiral(int rows, int columns)
{
  int[,] matrix = new int[rows, columns];
  int temp = 1;
  int i = 0;
  int j = 0;

  while (temp <= rows * columns)
  {
    matrix[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
      j++;
    else if (i < j && i + j >= matrix.GetLength(0) - 1)
      i++;
    else if (i >= j && i + j > matrix.GetLength(1) - 1)
      j--;
    else
      i--;
  }
  return matrix;
}












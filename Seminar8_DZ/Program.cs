/* Задача 54: Задайте двумерный массив. Напишите программу,
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
Console.WriteLine($"Задача № 54");

int[,] numbers = GetMatrix(3, 4, 1, 9);
Print(numbers);
DescendingSort(numbers);
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

void DescendingSort(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int l = 0; l < matrix.GetLength(1) - 1; l++)
      {
        if (matrix[i, l] < matrix[i, l + 1])
        {
          int temp = matrix[i, l + 1];
          matrix[i, l + 1] = matrix[i, l];
          matrix[i, l] = temp;
        }
      }
    }
  }
}

/* Задача 56: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и
выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.WriteLine($"Задача № 56");

int[,] num = GetMatrix(4, 5, 1, 9);
Print(num);
Console.WriteLine();
NumberRowMinSumElements(num);
Console.WriteLine();

void NumberRowMinSumElements(int[,] matrix)
{
  int index = 0, minsum = 0;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      sum += matrix[i, j];
    }
    Console.WriteLine($"Сумма {i + 1} строки = {sum}");
    if (i == 0) minsum = sum;
    else if (sum < minsum)
    {
      minsum = sum;
      index = i;
    }
  }
  Console.WriteLine($"Строка № {index + 1} с наименьшей суммой элементов под индексом {index} ");
}
Console.WriteLine();

/* Задача 58: Задайте две матрицы. Напишите программу,
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

Console.WriteLine($"Задача № 58");

int[,] matrixA = GetMatrix(2, 2, 1, 9);
Print(matrixA);
Console.WriteLine();
int[,] matrixB = GetMatrix(2, 2, 1, 9);
Print(matrixB);
Console.WriteLine();
int[,] matrixC = new int[2, 2];
Print(ProductTwoMatrices(matrixA, matrixB));

int[,] ProductTwoMatrices(int[,] firstMatrix, int[,] secondMatrix)
{
  int[,] thirdMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];

  if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
    Console.WriteLine("Умножение невозможно!");
  else
  {
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
      for (int j = 0; j < secondMatrix.GetLength(1); j++)
      {
        int result = 0;
        for (int l = 0; l < secondMatrix.GetLength(0); l++)
        {
          result += firstMatrix[i, l] * secondMatrix[l, j];
        }
        thirdMatrix[i, j] = result;
      }
    }
  }
  return thirdMatrix;
}

/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив,
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

Console.WriteLine($"Задача № 60");

int[,,] Array = new int[2, 2, 2];
FillArray(Array);
PrintIndex(Array);

void PrintIndex(int[,,] array)// метод вывода индекса элементов  массива
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.WriteLine();
      for (int l = 0; l < array.GetLength(2); l++)
      {
        Console.Write($"{array[i, j, l]}({i},{j},{l}) ");
      }
    }
  }
}

void FillArray(int[,,] array)// метод заполнения  массива не повторяющимеся числами
{
  int count = 10;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int l = 0; l < array.GetLength(2); l++)
      {
        array[l, i, j] += count;
        count += 3;
      }
    }
  }
}






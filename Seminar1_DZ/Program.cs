//Задача 2: Напишите программу, которая на вход принимает
//два числа и выдает, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
  Console.WriteLine(numberA + " это большее число");
  Console.WriteLine(numberB + " это меньшее число");
}
else if (numberA < numberB)
{
  Console.WriteLine(numberB + " это большее число");
  Console.WriteLine(numberA + " это меньшее число");
}
else
{
  Console.WriteLine("  числа равны");
}


//Задача 4: Напишите программу, которая принимает на вход
//три числа и выдает максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (number2 > max)
{
  max = number2;
}

if (number3 > max)
{
  max = number3;
}
Console.WriteLine(" Максимальное из трёх чисел: " + max);


//Задача 6: Напишите программу, которая на вход принимает
//число и выдает, является ли число четным (делится ли оно на
//два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
  Console.WriteLine("Число " + num + " является чётным");
}
else
{
  Console.WriteLine("Число " + num + " является нечётным");
}


//Задача 8: Напишите программу, которая на вход принимает
//число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

int startNumber = 1;

while (startNumber <= num1)
{
  if (startNumber % 2 == 0)
  {
    Console.Write(startNumber + ", ");
  }
  startNumber++;
}






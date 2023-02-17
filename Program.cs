
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

System.Console.WriteLine("Введите числа:");
int[] array = CreatNewRandomArray(5);

int PositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count += 1;
        }
    }
    return count;
}

int[] CreatNewRandomArray(int size)
{
    int[] array = new int[size];

    for (var i = 0; i < size; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

System.Console.WriteLine($"Пользователь ввел {PositiveNumbers(array)} чисел больше 0");

// // Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// // значения b1, k1, b2 и k2 задаются пользователем.
// // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


  System.Console.Write("Задайте значение b1: ");
  double b1 = int.Parse(Console.ReadLine());

  System.Console.Write("Задайте значение b2: ");
  double b2 = int.Parse(Console.ReadLine());

  System.Console.Write("Задайте значение k1: ");
  double k1 = int.Parse(Console.ReadLine());

  System.Console.Write("Задайте значение k2: ");
  double k2 = int.Parse(Console.ReadLine());

  double x = (b2 - b1) / (k1 - k2);
  double y = k2 * x + b2;

  if ((y != k1 * x + b1) || (k1 - k2 == 0)) System.Console.WriteLine("Ошибка");
  else
  {
    System.Console.WriteLine($"Точка пересечения двух прямых, x, y: ({x}); ({y})");
  }

// // Выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// // Если N = 5
// // --> 0 1 1 2 3
// // Если N = 3
// // --> 0 1 1
// // Если N = 7
// // --> 0 1 1 2 3 5 8

int Fibonacci (int n)
{
return n > 1 ? Fibonacci(n - 1) + Fibonacci(n - 2) : n;
}

System.Console.WriteLine("Введите число n:");
DisplayFibonacci(int.Parse(Console.ReadLine()));
        
int DisplayFibonacci (int n)  
{

  for (int i = 0; i < n; i++)
  {
    System.Console.WriteLine(Fibonacci(i));
  }
  return Fibonacci(n);
}

// Задача 68:
//  Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
///////////////////////////////////////////////////////
  using System;

namespace AkkermanFunction
{
class Program
{
static int CalculateAkkermanFunction(int m, int n)
{
  if (m == 0)
    return n + 1;
  else if (n == 0)
    return CalculateAkkermanFunction(m - 1, 1);
    else
    return CalculateAkkermanFunction(m - 1, CalculateAkkermanFunction(m, n - 1));
}

    static void Main(string[] args)
    {
        Console.WriteLine("Введите значение m:");
        int m = Convert.ToInt32(Console.ReadLine()); 

        Console.WriteLine("Введите значение n:");
        int n = Convert.ToInt32(Console.ReadLine());

        int result = CalculateAkkermanFunction(m, n);

        Console.WriteLine($"Результат A({m}, {n}) = {result}");

}  }  } 
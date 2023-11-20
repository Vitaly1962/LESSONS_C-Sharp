// Задача 66:
// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/////////////////////////////////////////////////////////////////////


using System;

namespace SumOfNaturalNumbers
{
class Program
{
static void Main(string[] args)
{
Console.Write("Enter M: ");
int m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int result = RecursiveSum(m, n);
        Console.WriteLine($"Sum of natural numbers in range from {m} to {n} is: {result}");
        Console.ReadKey();
    }

    static int RecursiveSum(int m, int n)
    {
        if (m > n)
            return 0;
        else
            return m + RecursiveSum(m + 1, n);
    }
}
}

////////////////////////////////////////
// Задача 66
// Задайте значения M и N. Напишите программу, которая выведет сумму
// всех натуральных чисел в промежутке от M до N с помощью рекурсии.

// using System;

// class Program {

// static void Main() {
//     Console.WriteLine("Введите значения M и N через пробел");
//     var input = Console.ReadLine().Split();
//     int M = int.Parse(input[0]);
//     int N = int.Parse(input[1]);

//     int result = CalculateSum(M,N);
//     Console.WriteLine(result);
// }

// private static int CalculateSum(int M, int N) {
//     if (M > N) {
//         return 0;
//     } else {
//         int sum = M + CalculateSum(M+1,N);
//         return sum;
//     }
// }
// }



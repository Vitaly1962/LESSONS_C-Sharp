// Задача 64: 
// Задайте значения M и N. Напишите программу,которая выведет все
// чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int ReadInt(string mes)
{
    Console.WriteLine(mes);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void PrintNaturalNum(int M, int N)
{
    if (N < M )
    {
        return ;
    }
    if(M % 2 == 0)
    {
    System.Console.Write($"{M}\t");
    }
    PrintNaturalNum(M + 1, N);
}

int M = ReadInt("Введите первое число");
int N = ReadInt("Введите второе число");
PrintNaturalNum(M, N);

// Определение строки с наименьшей суммой элементов
// Напишите программу для работы с матрицей целых чисел.
// Реализуйте класс Answer, который содержит следующие статические методы:
// SumOfRow(int[,] matrix, int row): Метод для вычисления суммы элементов в 
// заданной строке row матрицы matrix. Метод принимает двумерный массив целых 
// чисел matrix и номер строки row, а возвращает целое число - сумму элементов в данной строке.
// MinimumSumRow(int[,] matrix): Метод для определения строки с наименьшей суммой элементов. 
// Метод принимает двумерный массив целых чисел matrix и возвращает массив из двух элементов: 
// номер строки с наименьшей суммой (нумерация начинается с 0) и саму сумму.

// Аргументы, передаваемые в метод/функцию:

// '9, 1, 7; 1, 2, 3; 4, 5, 6'
// На выходе:


// Исходная матрица:
// 9   1   7   
// 1   2   3   
// 4   5   6   

// Сумма наименьшей строки (строка 2): 6
// Сумма элементов в строке 2: 6

// int[,] CreateMatrix (int row, int col, int min, int max) 
// {
//     int[,] matrix = new int[row, col];
//     Random rnd = new Random();   
//     for (int i = 0; i < matrix.GetLength(0); i++) 
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = rnd.Next(min, max +1);
//         }
//     }
//     return matrix;
// } 

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i <  matrix.GetLength(0); i++)
//     {
//         Console.Write("|");
//         for (int j = 0; j < matrix.GetLength(1); j++) 
//         {
//             if (j < matrix.GetLength(1) -1) Console.Write($"{matrix[i, j], 1}|");
//             else Console.Write($"{matrix[i, j], 1}");
//         }
//         Console.WriteLine("|");        
//     }        
// }

// void SumStringMatrix(int[,] matrix)
// {
//     int index = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         int sum = 0;
//         int minsum = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             sum += matrix[i, j];
//             if (sum <= minsum) sum = minsum;
//             index = i;        
            
//         }
//         Console.Write($"Строка с минимальной суммой элементов равна {matrix[index, sum]}. ");
//     }            
// }
   

// int[,] array2D = CreateMatrix(3, 4, 0, 9);
// PrintMatrix(array2D);
// SumStringMatrix(array2D);

///////////////////////////////////////////


Console.Write("Введите размерность m массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность n массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[m,n];
void mas(int m, int n)
{
int i,j;
Random rand = new Random();
for (i = 0; i < m; i++)
{
for (j = 0; j < n; j++)
{
randomArray[i,j] = rand.Next(1,9);
}
}
}

void printm(int[,] array)
{
int i,j;
for (i = 0; i < array.GetLength(0); i++)
{
Console.WriteLine();
for (j = 0; j < array.GetLength(1); j++)
{
Console.Write($"{array[i,j]} ");
}
Console.WriteLine();
}
}

mas(m,n);
Console.WriteLine("\nИсходный массив: ");
printm(randomArray);

// Функция, считающая сумму элементов в строке
int SumLine(int[,] array, int i)
{
int sum = array[i,0];
for (int j = 1; j < array.GetLength(1); j++)
{
sum += array[i,j];
}
return sum;
}

int minSum = 1;
int sum = SumLine(randomArray, 0);
for (int i = 1; i < randomArray.GetLength(0); i++)
{
if (sum > SumLine(randomArray, i))
{
sum = SumLine(randomArray, i);
minSum = i+1;
}
}
Console.WriteLine($"\nСумма наименьшей строки (Строка {minSum}):{sum}");
Console.Write($"\nСумма элементов в строке  {minSum}: {sum} ");
Console.WriteLine();
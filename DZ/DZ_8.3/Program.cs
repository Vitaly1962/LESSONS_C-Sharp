// Умножения двух матриц
// Реализуйте класс MatrixOperations, который содержит следующие статические методы:
// MultiplyIfPossible(int[,] matrixA, int[,] matrixB): Метод для проверки, возможно ли
//  умножения двух матриц matrixA и matrixB. Если число столбцов в матрице matrixA не 
//  равно числу строк в матрице matrixB, то выводится сообщение "It is impossible to multiply.
//  " В противном случае, вызывается метод MatrixMultiplication для умножения матриц, 
//  и результат выводится с помощью метода PrintMatrix.
// MatrixMultiplication(int[,] matrixA, int[,] matrixB): Метод для умножения двух матриц matrixA
//  и matrixB. Метод возвращает новую матрицу, которая представляет собой результат умножения 
//  матрицы matrixA на матрицу matrixB.
// PrintMatrix(int[,] matrix): Метод для вывода матрицы на консоль.
// Если аргументы не переданы, программа использует матрицы по умолчанию. 
// Если аргументы переданы, программа парсит их в двумерные массивы целых чисел и выполняет умножение матриц.
// Аргументы, передаваемые в метод/функцию:

// '1,2;3,4'
// На выходе:

// Исходная матрица:
// 1   2   
// 3   4   

// Matrix B:
// 5   6   
// 7   8   

// Multiplication result:
// 19  22  
// 43  50
///////////////////////////////////////////////////

// В C# можно создать класс с методами для выполнения умножения матриц. Вот пример такого класса:

// using System;
// using System.Linq;

// class Matrix
// {
//     private int[,] _matrix;

//     public Matrix(string[] matrixData)
//     {
//         _matrix = matrixData.Select(x => x.Split(';')).Select(x => new[] { int.Parse(x[0]), int.Parse(x[1]) }).ToArray();
//     }

//     public void Print()
//     {
//         Console.WriteLine("Матрица:");
//         for (int i = 0; i < _matrix.Length; i++)
//         {
//             Console.Write($"{_matrix[i, 0]}  ");
//             for (int j = 1; j < _matrix[i].Length; j++)
//                 Console.Write($"{_matrix[i, j]}  ");
//             Console.WriteLine();
//         }
//         Console.WriteLine("");
//     }


//     // Проверка возможности умножения
//     public bool CanMultiply(Matrix other)
//     {
//         return _matrix.
 
// GetLength(1) == other._matrix.GetLength(0);
// }

// // Умножение матриц
// public Matrix Multiply(Matrix other)
// {
//     if (!CanMultiply(other))
//         throw new Exception("Невозможно умножить матрицы!");

//     int[,] result = new int[_matrix.GetLength(0), other._matrix.GetLength(1)];

//     for (int i = 0; i < result.GetLength(0); i++)
//         for (int j = 0; j < result.GetLength(1); j++)
//             for (int k = 0; k < _matrix.GetLength(1); k++)
//                 result[i, j] += _matrix[i, k] * other._matrix[k, j];

//     return new Matrix(result.Cast<double>().ToArray());
// }
// }

// class Program
// {
// static void Main(string[] args)
// {
//     Matrix matrix1 = new Matrix("1,2;3,4".Split(?){};})});:"|}{','));}}
////////////////////////////////////////////////////////////////////////////////////

// Умножения двух матриц
// Реализуйте класс MatrixOperations, который содержит следующие статические методы:
// MultiplyIfPossible(int[,] matrixA, int[,] matrixB): Метод для проверки, 
// возможно ли умножения двух матриц matrixA и matrixB. Если число столбцов в 
// матрице matrixA не равно числу строк в матрице matrixB, то выводится сообщение 
// "It is impossible to multiply." В противном случае, вызывается метод MatrixMultiplication
//  для умножения матриц, и результат выводится с помощью метода PrintMatrix.
// MatrixMultiplication(int[,] matrixA, int[,] matrixB): Метод для умножения двух матриц 
// matrixA и matrixB. Метод возвращает новую матрицу, которая представляет собой результат
//  умножения матрицы matrixA на матрицу matrixB.
// PrintMatrix(int[,] matrix): Метод для вывода матрицы на консоль.
// Если аргументы не переданы, программа использует матрицы по умолчанию. 
// Если аргументы переданы, программа парсит их в двумерные массивы целых 
// чисел и выполняет умножение матриц.
// Аргументы, передаваемые в метод/функцию:

// '1,2;3,4'
// На выходе:

// Исходная матрица:
// 1   2   
// 3   4   

// Matrix B:
// 5   6   
// 7   8   

// Multiplication result:
// 19  22  
// 43  50


//////////////////////////////////////////////////////////////////////////

using System;

// класс с методами расширения
static class MatrixExt
{
    // метод расширения для получения количества строк матрицы
    public static int RowsCount(this int[,] matrix)
    {
        return matrix.GetUpperBound(0) + 1;
    }

    // метод расширения для получения количества столбцов матрицы
    public static int ColumnsCount(this int[,] matrix)
    {
        return matrix.GetUpperBound(1) + 1;
    }   
}

class Program
{
    // метод для получения матрицы из консоли
    static int[,] GetMatrixFromConsole(string name)
    {
        Console.Write("Количество строк матрицы {0}:    ", name);
        var n = int.Parse(Console.ReadLine());
        Console.Write("Количество столбцов матрицы {0}: ", name);
        var m = int.Parse(Console.ReadLine());

        var matrix = new int[n, m];
        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < m; j++)
            {
                Console.Write("{0}[{1},{2}] = ", name, i, j);
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        return matrix;
    }

    // метод для печати матрицы в консоль
    static void PrintMatrix(int[,] matrix)
    {
        for (var i = 0; i < matrix.RowsCount(); i++)
        {
            for (var j = 0; j < matrix.ColumnsCount(); j++)
            {
                Console.Write(matrix[i, j].ToString().PadLeft(4));
            }

            Console.WriteLine();
        }
    }

    // метод для умножения матриц
    static int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
    {       
        if (matrixA.ColumnsCount() != matrixB.RowsCount())
        {
            throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
        }

        var matrixC = new int[matrixA.RowsCount(), matrixB.ColumnsCount()];

        for (var i = 0; i < matrixA.RowsCount(); i++)
        {
            for (var j = 0; j < matrixB.ColumnsCount(); j++)
            {
                matrixC[i, j] = 0;

                for (var k = 0; k < matrixA.ColumnsCount(); k++)
                {
                    matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

        return matrixC;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Программа для умножения матриц");

        var a = GetMatrixFromConsole("A");
        var b = GetMatrixFromConsole("B");

        Console.WriteLine("Матрица A:");
        PrintMatrix(a);

        Console.WriteLine("Матрица B:");
        PrintMatrix(b);

        var result = MatrixMultiplication(a, b);
        Console.WriteLine("Произведение матриц:");
        PrintMatrix(result);

        Console.ReadLine();
    }
}


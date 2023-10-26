// Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// using System;

// public class Answer
// {
//     private static double Length(int[] pointA, int[] pointB)
//     {
//     int x1 =pointA[0];
//     int y1 =pointA[1];
//     int z1 =pointA[2];

//     int x2 =pointB[0];
//     int y2 =pointB[1];
//     int z2 =pointB[2];

//     double distanse = Math.Sqrt(Math.Pow(x2-x1,2)
//      + Math.Pow(y2-y1,2)+ Math.Pow(z2-z1,2));
//     return distanse;
       
//     }

//   // Не удаляйте и не меняйте метод Main! 
//     public static void Main(string[] args) {
//         int x1, x2, x3, y1, y2, y3;

//         if (args.Length >= 6) {
//             x1 = int.Parse(args[0]);
//             x2 = int.Parse(args[1]);
//             x3 = int.Parse(args[2]);
//             y1 = int.Parse(args[3]);
//             y2 = int.Parse(args[4]);
//             y3 = int.Parse(args[5]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             x1 = 3;
//             x2 = 6;
//             x3 = 8;
//             y1 = 2;
//             y2 = 1;
//             y3 = -7;
//         }

//         // Не удаляйте строки ниже
//         double result = Length(new int[]{x1, x2, x3}, new int[]{y1, y2, y3});
//         Console.WriteLine($"{result:F2}");
//     }
// }

////////////////////////////////////////////////////////////////////////////////////

using System;

public class Answer
{
    private static int Square(int number)
    {
        return number * number;
    }

    private static int SumSquare(int[] pointA, int[] pointB)
    {
        int sum = 0;
        for (int i = 0; i < pointA.Length; i++)
        {
            sum += Square(pointA[i] - pointB[i]);
        }
        return sum;
    }

    private static double Length(int[] pointA, int[] pointB)
    {
        double result = Math.Sqrt(SumSquare(pointA, pointB));
        return result;
    }

    public static void Main(string[] args) 
    {
        int x1, x2, x3, y1, y2, y3;

        if (args.Length >= 6)
        {
            x1 = int.Parse(args[0]);
            x2 = int.Parse(args[1]);
            x3 = int.Parse(args[2]);
            y1 = int.Parse(args[3]);
            y2 = int.Parse(args[4]);
            y3 = int.Parse(args[5]);
        }                
        else 
        {
            x1 = 3;
            x2 = 6;
            x3 = 8;
            y1 = 2;
            y2 = 1;
            y3 = -7;
        }

        double result = Length(new int[]{x1, x2, x3}, new int[]{y1, y2, y3});
        Console.WriteLine($"{result:F2}");
    }
  }
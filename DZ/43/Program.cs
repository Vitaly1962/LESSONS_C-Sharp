using System;

public class Answer
{
   static void ShowCube(int N)
    {
      // Введите свое решение ниже
       for (int i = 1; i <= N; i++)
{ 
    System.Console.WriteLine(System.Console.WriteLine);();($"{i*i*i} ");
}
        
    }

  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int N;

        if (args.Length >= 1) {
            N = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            N = 5;
        }

        // Не удаляйте строки ниже
        ShowCube(N);
    }
     }

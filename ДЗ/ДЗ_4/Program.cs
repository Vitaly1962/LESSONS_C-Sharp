using System;
//которая на вход принимает число (number), а на выходе выводит 
//все чётные числа от 1 до number (включительно), 
//разделеные знаком табуляции.

public class Answer {
    static void PrintEvenNumbers(int number)
    {
      // Введите свое решение ниже


int num = int.Parse(Console.ReadLine());
int even = 2;

while (num >= even)
{
    Console.Write(even + " ");
    even = even + 2;
}

    }

  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 6;
        }

        // Не удаляйте строки ниже
        PrintEvenNumbers(number);
    }
}
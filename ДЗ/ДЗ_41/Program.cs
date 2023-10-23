// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

// Public Class Answer;
// {
//   static bool IsPalindrome(int number);
   
//    if(number < 10000 || number > 99999)
//     {
//      Console.WriteLine("Число не пятизначное");
//      return false;
//     }
//     //Преобразовать число в строку
//     string numberString = number.ToString();
//     //Проверить на полидромность
//     int length = numberString.Length;
//     for(int i = 0; i < length / 2; i++)
//     {
//       if (numberString[i] != numberString[length - i - 1])
//        {
//         return false;
//        }
       
//     }
//      return true;
     
//   int number = 12321;
//   bool isPalindrome = Answer.IsPalindrome(number);
//   Console.WriteLine(isPalindrome);
//   number = 1234;
//   isPalindrome = Answer.IsPalindrome(number);
//   Console.WriteLine(isPalindrome);


// }

// 14212 -> нет
// 12821 -> да
// 23432 -> да
// */
////////////////////////////////////////////////////////////
// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine();
// int len = number.Length;

// if (len == 5)
// {
//     if (number[0] == number[4] && number[1] == number[3])
//     {
//         Console.WriteLine($"{number} --> True");
//     }
//     else
//     {
//         Console.WriteLine($"{number} --> False");
//     }
// }
// else
// {
//     Console.WriteLine($"{number} --> Число не пятизначное: ");
//     Console.WriteLine($" -False");
// }
//////////////////////////////////////////////////////////////////
//  using System;

// public class Answer
// {
//     static bool IsPalindrome(int number){
//       // Введите свое решение ниже
//       if(number < 10000 || number > 99999)
//       {
//         Console.WriteLine("Число не пятизначное");
//         return false;
//       }
//       //Преобразование числа в строку
//         string numberString = number.ToString();
//       //Проверка на полидромность
//         int length = numberStringth.Length;
//         For(int i = 0; i < length/2; i++)
//         {
//           if(numberString[i] != numberString[length - i-1])
//           {
//             return false;
//            }
//          }
//     }       return true;
  
//   // Не удаляйте и не меняйте метод Main! 
//       static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             number = 64546;
//         }

//         // Не удаляйте строки ниже
//         bool result = IsPalindrome(number);
//         Console.WriteLine($"{result}");
//     }
// }   
////////////////////////////////////////

// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да


Console.Write("Введите число: ");
int number = Console.ReadLine();

      if(number < 10000 || number > 99999)
      {
        Console.WriteLine($"{number} --> Число не пятизначное: ");
        Console.WriteLine($" -False");
      }

void CheckingNumber(int number)
{
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"Ваше число: {number} - палиндром.");
  }
  else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
}

if (number!.Length == 5){
  CheckingNumber(number);
}
else Console.WriteLine($"Введи правильное число");


//Console.WriteLine($"{number} --> Число не пятизначное: ");
//Console.WriteLine($" -False");
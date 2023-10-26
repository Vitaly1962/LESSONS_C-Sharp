// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да


// Console.Write("Введите число: ");
// string? number = Console.ReadLine();

// void CheckingNumber(string number)
// {
//   if (number[0]==number[4] || number[1]==number[3])

//     {
//         Console.WriteLine($"Ваше число: {number} -->  True.");
//     }

//   else Console.WriteLine($"Ваше число: {number} -->  False.");
// }

//     if (number!.Length == 5)
//     {
//      CheckingNumber(number);
//     }
    
//     else Console.WriteLine($"{number} -->  Число не пятизначное: -False");
         
    
    /////////////////////////////////////////////////////////////////////////////

int num,r,sum=0,t;
Console.Write("Введите пятизначное число: ");
num = Convert.ToInt32(Console.ReadLine());
if(num>9999 && num<100000)
{
  for(t=num;num!=0;num=num/10)
  {
    r=num % 10;

    sum=sum*10+r;
  }
  if(t==sum)
  {
    Console.Write($"{t} является палиндромом."); 
  }
  
  else
  {
    Console.Write($"{t} не является палиндромом.");
  }
  
} else
Console.Write("Введите пятизначное число! ");
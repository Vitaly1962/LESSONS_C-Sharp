﻿// 3. Напишите программу вычисления функции:
//  x = f(a)

Console.WriteLine("Введите число больше нуля");// оповещения пользователя об ожидании ввода
string input = Console.ReadLine(); //считывание и сохранение строки с консоли
int num = Convert.ToInt32(input); //конвертация в целое числа с последующим присвоением переменной num

if(num < 0 || num = 0) // || - логическое или где хотя бы одно из утверждений должно быть истинно (true);
{
   Console.WriteLine("Число слишком маленькое");// результат неверной проверки на натуральность (целое больше 0)
}
else
{
    int i = -1 * num; // Высчитываем -N тем самым определяем начало счетчика цикла
    while (i <= num) // цикл с условием
    {
       Console.Write(i + " "); // вывод числа
        i++; //увеличение на 1;
    }
}

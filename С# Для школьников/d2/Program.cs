﻿
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа. 456 -> 6 782 -> 2 918 -> 8
int ReadInt(string msg) // объявляем функцию РидИнт и строковый параметр msg
{
    Console.WriteLine(msg); // пишет в консоль параметр msg
    string numb = Console.ReadLine();//функция считывания строки с консоли(с терминала)
    int number; //вводим переменную намбер 
    number = int.Parse(numb);// как результат преобразования строки в число 
    return number; // возврат из функции
} // описание функции заканчивается
int number= ReadInt("введите трехзначное число");// вызываем функцию РидИнт и передаем в эту функцию "Введите трехзначное число".
                                    //Результат складываем в новую переменную намбер
if (number < 1000 & number > 99)    // если намбер трехзначное то продолжаем вычисления
{
    int lastDigit = number % 10; // вводим переменную Последнее число равно остаток от деления намб на 10
    Console.WriteLine("lastDigit=" + lastDigit); // выводим в консоль последнее число

}
else Console.WriteLine("lastDigit not three digits");//  если намбер не трехзначное то выводим пользователю "некорректно введенные данные"




// 2. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

int number = new Random().Next(10,100); // Сгенерировали случайное число в диапазоне от 10 до 99 и переместили в переменную number
Console.WriteLine("Number =" + number);
int firstDigit = number / 10; 
int lastDigit = number % 10;
if(firstDigit > lastDigit)
{
    Console.WriteLine(firstDigit);
}
else
{
    Console.WriteLine(lastDigit);
}
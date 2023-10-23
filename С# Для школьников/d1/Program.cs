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
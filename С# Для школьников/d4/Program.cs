//4. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//14 -> нет 
//46 -> нет 
//161 -> да

int ReadInt(string msg) // объявляем функцию РидИнт и строковый параметр msg
{
    Console.WriteLine(msg); // пишет в консоль параметр msg
    string numb = Console.ReadLine();//функция считывания строки с консоли(с терминала)
    int number; //вводим переменную намбер 
    number = int.Parse(numb);// как результат преобразования строки в число 
    return number; // возврат из функции
} // описание функции заканчивается
int number = ReadInt("Вудите число");
int result1 = number %7;
int result2 = number %7;
(result1 == 0 & result2 == 0)
{
    Console.WriteLine("Да");
}
else



int ReadInt(string msg) // объявляем функцию РидИнт и строковый параметр msg
{
    Console.WriteLine(msg); // пишет в консоль параметр msg
    string numb = Console.ReadLine();//функция считывания строки с консоли(с терминала)
    int number; //вводим переменную намбер 
    number = int.Parse(numb);// как результат преобразования строки в число 
    return number; // возврат из функции
} // описание функции заканчивается
int number = ReadInt("Введите число");
int result1 = number %7;
int result2 = number %23;
if (result1 == 0 && result2 ==0)
{
    Console.WriteLine("Да");
} 
else
{
    Console.WriteLine("Нет");
}
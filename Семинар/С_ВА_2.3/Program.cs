//3. Напишите программу, которая будет принимать на вход два числа и выводить,
//является ли второе число кратным первому. Если число 2 не кратно числу 1, 
//то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно

int ReadInt(string msg) // объявляем функцию РидИнт и строковый параметр msg
{
    Console.WriteLine(msg); // пишет в консоль параметр msg
    string numb = Console.ReadLine();//функция считывания строки с консоли(с терминала)
    int number; //вводим переменную намбер 
    number = int.Parse(numb);// как результат преобразования строки в число 
    return number; // возврат из функции
} // описание функции заканчивается

int number1 = ReadInt("Ведите первое число");
int number2 = ReadInt("Ведите второе число");
int result = number1 %number2;
if (rezalt==0)
{
Console.WriteLine("Первое число кратное второму")
}
els


int ReadInt(string msg) // объявляем функцию РидИнт и строковый параметр msg
{
    Console.WriteLine(msg); // пишет в консоль параметр msg
    string numb = Console.ReadLine();//функция считывания строки с консоли(с терминала)
    int number; //вводим переменную намбер 
    number = int.Parse(numb);// как результат преобразования строки в число 
    return number; // возврат из функции
} // описание функции заканчивается
int number1 = ReadInt("Введите первое число");
int number2 = ReadInt("Введите второе число");
int result = number1  %number2;
if (result==0)
{
    Console.WriteLine(" Первое число кратно второму");
}
else 
{
    Console.WriteLine("Не кратно " + result);
}
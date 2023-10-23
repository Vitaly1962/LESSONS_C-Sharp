int ReadInt(string msg) // объявляем функцию РидИнт и строковый параметр msg
{
    Console.WriteLine(msg); // пишет в консоль параметр msg
    string numb = Console.ReadLine();//функция считывания строки с консоли(с терминала)
    int number; //вводим переменную намбер 
    number = int.Parse(numb);// как результат преобразования строки в число 
    return number; // возврат из функции
}

int Digit = ReadInt ("Введите число:");
int n=0;
while (Digit>0)
{
Digit/=10;
n=n+1;
}
Console.WriteLine(n);
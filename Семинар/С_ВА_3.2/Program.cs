https://docs.google.com/presentation/d/1aS5Dec5fAMizFS748DdEB7ltXjAKs0UxDVWDAQd9NWI/edit?usp=sharing

22:25
//Задача 2: Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).
int readQuoter(string message) {
    System.Console.WriteLine(messege);
    string vaile = Console.ReadLine();
    return int.Parse(vaile); //
}
int quoter = readQuoter(" Введите номер четверти");
if (quoter > 0 & quoter < 5)
{
    if (quoter)

}



//Задача 2.
//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
int readQuater(string message)
{
    System.Console.WriteLine(message); // Получаем данные из строки.
    string value = Console.ReadLine();// Вызов консольного ввода, value - значение, которое вводим.
    return int.Parse(value); // Возрвращаем переменную в int.
}
int quater = readQuater("Введите номер четверти:");
if (quater > 0 && quater < 5)
{
    switch (quater)
    {
        case 1: System.Console.WriteLine("X>0 и Y>0"); break;
        case 2: System.Console.WriteLine("X<0 и Y>0"); break;
        case 3: System.Console.WriteLine("X<0 и Y<0"); break;
        default: System.Console.WriteLine("X>0 и Y<0"); break;

    }
    // if (quater == 1)
    // {
    //     System.Console.WriteLine("X>0 и Y>0");
    // }
    // if (quater == 2)
    // {
    //     System.Console.WriteLine("X<0 и Y>0");
    // }
    // if (quater == 3)
    // {
    //     System.Console.WriteLine("X<0 и Y<0");
    // }
    // if (quater == 4)
    // {
    //     System.Console.WriteLine("X>0 и Y<0");
    // }
}
else System.Console.WriteLine("Данные введены неверно.");

int readQuoter(string message)
{
    System.Console.WriteLine(message); // Получаем данные из строки.
    string value = Console.ReadLine(); // Вызов консольного ввода, value - значение, которое вводим.
    return int.Parse(value); // возрвращаем переменную в int.
}
int quoter = readQuoter(" введите номер четверти");
if (quoter > 0 & quoter < 5)
{
    switch (quoter)
    {
        case 1: Console.WriteLine("x>0 и y>0"); break;
        case 2: Console.WriteLine("x<0 и y>0"); break;
        case 3: Console.WriteLine("x<0 и y<0"); break;
        default: Console.WriteLine("x>0 и y<0"); break;
    }

}
else Console.WriteLine(" данные введены неверно");



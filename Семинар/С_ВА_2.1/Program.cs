// 1. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int enterCoordinate(string message) // Ввод переменных.
{
    System.Console.WriteLine(message); // Получаем данные из строки.
    string value = Console.ReadLine(); // Вызов консольного ввода, value - значение, которое вводим.
    return int.Parse(value); // возрвращаем переменную в int.
}

bool checkValidate(int x, int y) // проверку ввода пользователя что x и y не равен 0.
{
    if(x == 0 || y == 0) // если x = 0 и y = 0, || - или.
    {
        Console.WriteLine("Координата X или Y равна нулю!"); // 
        return false; // проверка не прошла.
    }
    return true; // проверка прошла.
}

int checkCategory(int x, int y) // за определение категории, где находится координата.
{
    if(x > 0 && y > 0){ // определяем номер четверти.
        return 1;
    }
    
    if(x < 0 && y > 0){ // определяем номер четверти.
        return 2;
    }

    if(x < 0 && y < 0){ // определяем номер четверти.
        return 3;
    }
    
    return 4; // остаток, если всё false. 
}

int x = enterCoordinate("Введите координату X: "); // вызов функции enterCoordinate
int y = enterCoordinate("Введите координату Y: ");

if(checkValidate(x, y)) // исполняемый код.
{
    System.Console.WriteLine("Номер четверти равен: " + checkCategory(x, y));
}

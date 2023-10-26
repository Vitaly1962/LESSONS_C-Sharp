// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

//

int[] createMassive(int length)   // создание массива, указание длины.
{
    int[] massive = new int [length]; // создаем новый массив с указанием размера.
    int i = 0; 
    
    Console.WriteLine();
    while(i < massive.Length)  // пока счётчик меньше размера массива
    { 
        Console.Write("Введите число "+ (i+1) + ':');
        int number=Int32.Parse(Console.ReadLine( ));

        massive[i] = number; // заполняем массив числами; 
        i++;
    }
    return massive; // возвращаем массив.
}
    
void printMassive(int[] massive)  // выводим массив.
{      Console.Write("[");                            
    foreach (var item in massive)  // удобный метод вывода массива, создан специально для работы с коллекциями и массивами.
       // Все ячейки внутри массива - это item.
    
    {
        Console.Write(item + ", ");
    }    Console.Write("]");
}

 int[] massive = createMassive(8); // создаем массив
printMassive(massive ); // выводим массив в консоле
 Console.WriteLine();

 int count = 0;
string input = Console.ReadLine();
foreach (int c in massive)
{
if (c > 0)
{
count++;
}
}
Console.WriteLine(count);
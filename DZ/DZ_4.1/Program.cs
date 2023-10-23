int[] createMassive(int length){ // создание массива, указание длины.
    int[] massive = new int [length]; // создаем новый массив с указанием размера.
    int i = 0; 
    
    System.Console.WriteLine();
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

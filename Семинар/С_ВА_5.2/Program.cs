/* Задача 2: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да */

// Функция генерации массива
// int[] generateArray(int length, int minValue, int maxValue)
// {
//     int[] numbers = new int[length];            // Создаем пустой массив (все элемента = 0)
//     Random random = new Random();               // создание генератора случайных чисел
//     for (int i = 0; i < numbers.Length; i++)    // заполнение массива случайными числами
//     {
//         numbers[i] = random.Next(minValue, maxValue + 1); // заполнение текущего элемента массива случайным числом в диапазоне [minValue..maxValue]
//     }
//     return numbers;
// }

// // Функция вывода массива на экран
// void printArray(int[] array)
// {
//     System.Console.Write(array[0]);             // Вывод 1-го элемента массива
//     for (int i = 1; i < array.Length; i++)
//     {
//         System.Console.Write($", {array[i]}");  // Вывод текущего элемента массива
//     }
//     System.Console.WriteLine();                 // Перевод строки (чтобы отделять массивы)
// }

// bool searchNumbers(int[] array, int number)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] == number){
//             return true;
//         }
//     }
//     return false;
// }

// int[] collections = generateArray(12, -9, 9);
// printArray(collections);
// Console.WriteLine(searchNumbers(collections, 1) ? "Да" : "Нет");


// Владимир Морозов
// Администратор
// Задача 3: Задайте одномерный массив из 10 случайных чисел в диапазоне от 1 до 200. Найдите количество  двузначных элементов массива. 
// Пример для массива из 5, а не 10 элементов. В своём решении сделайте для 10
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
// Задача 3: Задайте одномерный массив из 10 случайных чисел в диапазоне от 1 до 200. Найдите количество  двузначных элементов массива. 
// Пример для массива из 5, а не 10 элементов. В своём решении сделайте для 10
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int[] GenerateArray(int length = 20)// методы в сишарп с большой буквы.
// {
//     int[] array = new int[length];// объявляем массив с таким размером
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(200);
//     }
//     return array;
// }
// void PrintArray(int[] array)
// {
//     foreach (int item in array)// находим каждый элемент в массиве.
//     {
//         Console.Write(item + " ");
//     }
//     Console.WriteLine();
// }
// int CountToDigit(int[] arr)
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (10 <= arr[i] && arr[i] < 100)
//             count++;

//     }
//     return count;
// }
// int [] Array=GenerateArray(10);
// PrintArray(Array);
// Console.WriteLine($"{CountToDigit(Array)}");

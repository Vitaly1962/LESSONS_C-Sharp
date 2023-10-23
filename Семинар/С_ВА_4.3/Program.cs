// Задача 2: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120
int enterInteger(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int searchFactorial(int number){
    int i = 1;
    int result = 1;
    while(i <= number){
        result *= i;
        i++;
    }
    return result;
}

int number = enterInteger("Введите число: ");
Console.WriteLine(searchFactorial(number));
// Напишите программу, которая на вход принимает число и выдаёт его квадрат 
//(число умноженное на само себя).
// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

Console.Write("Ведите числа => ");
int inputData = int.Parse(Console.ReadLine());
int result = inputData * inputData;
Console.WriteLine("Квадрат числа " + inputData + " равен "+ result);
Console.WriteLine($"Квадрат числа {inputData} равен {result}");

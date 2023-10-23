Console.WriteLine("Введите число"); 
int  inputData = int.Parse(Console.ReadLine());// Ввод переменных.
if (inputData < 0)
 {
     inputData = -1*inputData;
 }
Console.WriteLine(inputData);
    
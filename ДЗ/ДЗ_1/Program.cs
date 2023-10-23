using System;

public class Answer {
    static void CompareNumbers(int firstNumber, int secondNumber)
    {
        // Введите свое решение ниже
        


int num1 = firstNumber;

int num2 = secondNumber;
if (num1 < num2)
{
    Console.WriteLine("Первое число"+" "+"`"+num1+"`"+" "+"меньше чем второе число"+" " +"`"+num2+"`"  );
   
}
else if (num1 == num2)
{
    Console.WriteLine( "Введенные числа равны "+" "+"`"+num1+"`");
}
else
{
    Console.WriteLine("Первое число"+" "+"`"+num1+"`"+" "+"больше чем второе число"+" " +"`"+num2+"`" );

}




    }


  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int firstNumber, secondNumber;

        if (args.Length >= 2) {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            firstNumber = 3;
            secondNumber = 5;
        }

        // Не удаляйте строки ниже
        CompareNumbers(firstNumber, secondNumber);
    }
}
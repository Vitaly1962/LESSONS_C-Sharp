//Напишите программу, которая принимает на вход число и выдаёт //сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12


Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int len = Length(a);
Console.Write($"Сумма цифр в числе {a} равно: {Sum(a,len)}");

// Подсчет количества символов в числе
int Length(int a)
{
int index = 0;
while (a > 0)
{
a = a / 10;
index++;
}
return index;
}

int Sum(int a, int len)
{
int sum = 0;
for (int i = 1; i <= len; i++)
{
sum = sum + a % 10;
a = a / 10;
}
return sum ;
}

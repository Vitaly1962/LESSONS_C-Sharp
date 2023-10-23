/// void WriteHelloJo()
// {
// Console.WriteLine($"Hello Jo");
// }
// void WriteHelloSam()
// {
// Console.WriteLine($"Hello Sam");
// }
// void WriteHelloYou()
// {
// Console.WriteLine($"Hello You");
// }
// //Затем необходимо вызвать их следующим образом:
// WriteHelloJo();
// WriteHelloSam();
// WriteHelloYou();
////////////////////////////////////////
// void WriteHello(string someName)
// {
// Console.WriteLine("Hello " + someName);
// }
// //и затем вызвать метод следующим образом:
// WriteHello("Jo");
// WriteHello("Sam");
// WriteHello("You");
//////////////////////////////////

// void WriteHello(string firstName, string lastName)
// {
// Console.WriteLine("Hello " + firstName + " " + lastName);
// }
// //А при вызове метода необходимо подставить правильное количество значений:
// WriteHello("Petr", "Ivanov");

///////////////////////////////////////////////////////////////////////////////

int NumberOfLegs(string animalName)
{
if (animalName == "слон") //Если название животного — слон
{
// Возвращаемое значение 4
return 4;
}
else if (animalName == "индейка") //Иначе, если животное — индейка
{
// Возвращаемое значение 2
return 2;
}
else if (animalName == "устрица")//Иначе, если животное — устрица
{
// Возвращаемое значение 1
return 1;
}
else //Иначе (при всех других условиях)
{
// Возвращаемое значение 0
return 0;
}
}
//Теперь мы можем вызвать метод. Давайте сделаем это дважды:
int i;
//Переменная “i” будет хранить значение числа конечностей.
i = NumberOfLegs("индейка");
//Теперь i = 2, получив значение, возвращенное методом NumberOfLegs
Console.WriteLine("У индейки конечностей – " + i);
i = NumberOfLegs("обезьяна");
//Теперь i = 0. Догадайтесь, почему!
Console.WriteLine("У обезьяны конечностей – " + i);
//////////////////////////////////////////////////////////////

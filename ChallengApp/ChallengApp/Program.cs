using ChallengApp;
using System;
using System.ComponentModel.Design;

Console.WriteLine("Program wykonany podczas nauki programowania w C# podstawy w ramach zadania dnia 6");
Console.WriteLine("Program wyszykuje pracownika, który posiada najwyższą liczbą ocen. oraz wyświetla jego wynik.");

Employees Employee1 = new Employees("Jan", "Kowalski", 45);
Employees Employee2 = new Employees("Janina", "Kowalska", 42);
Employees Employee3 = new Employees("Janeczek", "Kowalski", 32);

Employee1.AddScore(10);
Employee1.AddScore(4);
Employee1.AddScore(6);
Employee1.AddScore(5);
Employee1.AddScore(6);

Employee2.AddScore(10);
Employee2.AddScore(4);
Employee2.AddScore(10);
Employee2.AddScore(8);
Employee2.AddScore(4);

Employee3.AddScore(6);
Employee3.AddScore(5);
Employee3.AddScore(4);
Employee3.AddScore(6);
Employee3.AddScore(7);

if (Employee1.Result > Employee2.Result && Employee1.Result > Employee3.Result)
{
    Console.WriteLine(Employee1.Result + " Pierwszy pracownik zdobył najwieksza ocenę " + Employee1.FristName + " " + Employee1.SecondName + " " + Employee1.Age);
}
else if (Employee2.Result > Employee3.Result && Employee2.Result > Employee1.Result)
{
    Console.WriteLine(Employee2.Result + " Drugi pracownik zdobył najwieksza ocenę " + Employee2.FristName + " " + Employee2.SecondName + " " + Employee2.Age);
}
else if (Employee3.Result > Employee2.Result && Employee3.Result > Employee1.Result)
{
    Console.WriteLine(Employee3.Result + " Trzeci pracownik zdobył najwieksza ocenę " + Employee3.FristName + " " + Employee3.SecondName + " " + Employee3.Age);
}
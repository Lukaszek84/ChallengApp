﻿using ChallengApp;
using System;
using System.ComponentModel.Design;

Console.WriteLine("Program wykonany podczas nauki programowania w C# podstawy w ramach zadania dnia 6");
Console.WriteLine("Program wyszykuje pracownika, który posiada najwyższą liczbą ocen. oraz wyświetla jego wynik.");

Employees employee1 = new Employees("Jan", "Kowalski", 45);
Employees employee2 = new Employees("Janina", "Kowalska", 42);
Employees employee3 = new Employees("Janeczek", "Kowalski", 32);

employee1.AddScore(10);
employee1.AddScore(4);
employee1.AddScore(6);
employee1.AddScore(5);
employee1.AddScore(6);

employee2.AddScore(10);
employee2.AddScore(4);
employee2.AddScore(10);
employee2.AddScore(8);
employee2.AddScore(4);

employee3.AddScore(6);
employee3.AddScore(5);
employee3.AddScore(4);
employee3.AddScore(6);
employee3.AddScore(7);

if (employee1.Result > employee2.Result && employee1.Result > employee3.Result)
{
    Console.WriteLine($"{employee1.Result} Pierwszy pracownik zdobył najwieksza ocenę {employee1.FristName} {employee1.SecondName} {employee1.Age}");
}
else if (employee2.Result > employee3.Result && employee2.Result > employee1.Result)
{
    Console.WriteLine($"{employee2.Result} Drugi pracownik zdobył najwieksza ocenę {employee2.FristName} {employee2.SecondName} {employee2.Age}");
}
else if (employee3.Result > employee2.Result && employee3.Result > employee1.Result)
{
    Console.WriteLine($"{employee3.Result} Trzeci pracownik zdobył najwieksza ocenę {employee3.FristName} {employee3.SecondName} {employee3.Age}");
}
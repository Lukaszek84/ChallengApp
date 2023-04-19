using ChallengApp;
using System;
using System.ComponentModel.Design;

Console.WriteLine("Program wykonany podczas nauki programowania w C# podstawy w ramach zadania dnia 6");
Console.WriteLine("Program wyszykuje pracownika, który posiada najwyższą liczbą ocen. oraz wyświetla jego wynik.");

Employee Employees1 = new Employee("Jan", "Kowalski", 45);
Employee Employees2 = new Employee("Janina", "Kowalska", 42);
Employee Employees3 = new Employee("Janeczek", "Kowalski", 32);

Employees1.AddScore(10);
Employees1.AddScore(4);
Employees1.AddScore(6);
Employees1.AddScore(5);
Employees1.AddScore(6);

Employees2.AddScore(10);
Employees2.AddScore(4);
Employees2.AddScore(10);
Employees2.AddScore(8);
Employees2.AddScore(4);

Employees3.AddScore(6);
Employees3.AddScore(5);
Employees3.AddScore(4);
Employees3.AddScore(6);
Employees3.AddScore(7);



if (Employees1.Result > Employees2.Result)
{
    if (Employees1.Result > Employees3.Result)
    {
        Console.WriteLine(Employees1.Result + " Pierwszy pracownik zdobył najwieksza ocenę " + Employees1.FristName + " " + Employees1.SecondName + " " + Employees1.Age);
    }
    else if (Employees3.Result > Employees2.Result)
    {
        Console.WriteLine(Employees3.Result + " Trzeci pracownik zdobył najwieksza ocenę " + Employees3.FristName + " " + Employees3.SecondName + " " + Employees3.Age);
    }
}
else if (Employees2.Result > Employees3.Result)
{
    Console.WriteLine(Employees2.Result + " Drugi pracownik zdobył najwieksza ocenę " + Employees2.FristName + " " + Employees2.SecondName + " " + Employees2.Age);
}
else if (Employees3.Result > Employees2.Result)
{
    if (Employees3.Result > Employees1.Result)
    {
        Console.WriteLine(Employees3.Result + " Trzeci pracownik zdobył najwieksza ocenę " + Employees3.FristName + " " + Employees3.SecondName + " " + Employees3.Age);
    }
}
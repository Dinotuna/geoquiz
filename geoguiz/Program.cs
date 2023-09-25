// See https://aka.ms/new-console-template for more information

using System;

int points = 0;

Console.WriteLine("Du ska svara på svåra frågor och få rätt nu");

Console.WriteLine("I vilken kontinent befinner sig USA i?");
Console.WriteLine("a) Europa b) Sydamerika c) Nordamerika");
string answer1 = Console.ReadLine();
if (answer1 == "c")
{
    points++;
    Console.WriteLine("Du hade rätt");
}
else 
{
    Console.WriteLine("Du hade förfan fel");
}

Console.WriteLine("Nu blir det lite svårare");
Console.WriteLine("Vad heter huvudstaden i Portugal");
Console.WriteLine("a) Lissabon b) Porto c) Marbella");
string answer2 = Console.ReadLine();
if (answer2 == "a")
{
    points++;
    Console.WriteLine("Du Hade rätt");
}
else{
    Console.WriteLine("Du hade fel hahaha");
}

Console.WriteLine("Nu blir det faktist svårt");
Console.WriteLine("Vad är huvudstaden i Trinidad och Tobago");
Console.WriteLine("a) Caracas b) Castries c) Port of Spain");
string answer3 = Console.ReadLine();
if (answer3 == "c")
{
    points++;
    Console.WriteLine("Du hade rätt");
}

else
{
    Console.WriteLine("Du hade fel, den var enkel");
}

Console.WriteLine("Nu kommer den sista och svåraste frågan");
Console.WriteLine("Skriv in Uzbekistans huvudstad");
string answer4 = Console.ReadLine();
if (answer4 == "Tashkent")
{
    points++;
    Console.WriteLine("Grattis du hade faktiskt rätt!");
}
else
{
    Console.WriteLine("Du hade fel du suger helt ärligt");
}

Console.WriteLine($"Du lyckades få {points} poäng");
if (points == 0)
{
    Console.WriteLine("Försökte du ens");
}
else if (points == 1)
{
    Console.WriteLine("");
}

Console.ReadLine();
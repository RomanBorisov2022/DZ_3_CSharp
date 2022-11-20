// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.Write("Введите пятизначное число: ");
int userInput = int.Parse(Console.ReadLine() ?? "");

int a = userInput / 10000;
int b = userInput % 10;
int c = (userInput % 10000) / 1000;
int d = (userInput / 10) % 10 ;
Console.WriteLine($"Результаты вычислений: {a}, {b}, {c}, {d}");

if(a == b & c == d)
    Console.WriteLine($"Результат: {userInput} -> да");
else
{
    Console.WriteLine($"Результат: {userInput} -> нет");
}
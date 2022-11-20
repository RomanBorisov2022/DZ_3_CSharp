// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

double X1 = userInput("Введите коодинату X1: ");
double Y1 = userInput("Введите коодинату X1: ");
double Z1 = userInput("Введите коодинату X1: ");
double X2 = userInput("Введите коодинату X1: ");
double Y2 = userInput("Введите коодинату X1: ");
double Z2 = userInput("Введите коодинату X1: ");

double result = DisPoint(X1, Y1, Z1, X2, Y2, Z2);
Console.WriteLine($"{result}");

static double DisPoint(
double X1, double Y1, double Z1, 
double X2, double Y2, double Z2)
{
    return Math.Sqrt()
}

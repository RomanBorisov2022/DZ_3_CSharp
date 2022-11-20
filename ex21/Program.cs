// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

double X1 = userInput("Введите коодинату X1: ");
double Y1 = userInput("Введите коодинату Y1: ");
double Z1 = userInput("Введите коодинату Z1: ");
double X2 = userInput("Введите коодинату X2: ");
double Y2 = userInput("Введите коодинату Y2: ");
double Z2 = userInput("Введите коодинату Z2: ");

double result = DistancePoints(X1, Y1, Z1, X2, Y2, Z2);

static double DistancePoints(double X1, double Y1, double Z1, double X2, double Y2, double Z2)
{
    return Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z2 - Z1, 2));
}

static double userInput(string message)
{
    Console.Write(message);
    return double.Parse(Console.ReadLine() ?? ""); 
}
Console.Write($"A({X1}, {Y1}, {Z1}) B({X2}, {Y2}, {Z2}) -> {result}");


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

System.Console.WriteLine("Введите координаты точки A x и y: ");

double cordxA = double.Parse(Console.ReadLine());

double cordyA = double.Parse(Console.ReadLine());

double cordzA = double.Parse(Console.ReadLine());

System.Console.WriteLine("Введите координаты точки B x и y: ");

double cordxB = double.Parse(Console.ReadLine());

double cordyB = double.Parse(Console.ReadLine());

double cordzB = double.Parse(Console.ReadLine());

double Dsqr = Math.Sqrt((Math.Pow((cordxB-cordxA),2))+(Math.Pow((cordyB-cordyA),2)));

System.Console.WriteLine(Dsqr);
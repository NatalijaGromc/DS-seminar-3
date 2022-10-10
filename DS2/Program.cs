// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int[] A = new int[3];
int[] B = new int[3];
Console.Write($"Введите координату X первой точки: ");
int.TryParse(Console.ReadLine()!, out A[0]);
Console.Write($"Введите координату Y первой точки: ");
int.TryParse(Console.ReadLine()!, out A[1]);
Console.Write($"Введите координату Z первой точки: ");
int.TryParse(Console.ReadLine()!, out A[2]);
Console.Write($"Введите координату X второй точки: ");
int.TryParse(Console.ReadLine()!, out B[0]);
Console.Write($"Введите координату Y второй точки: ");
int.TryParse(Console.ReadLine()!, out B[1]);
Console.Write($"Введите координату Z первой точки: ");
int.TryParse(Console.ReadLine()!, out B[2]);

double c = Math.Sqrt(Math.Pow((A[0] - B[0]), 2) + Math.Pow((A[1] - B[1]), 2)+Math.Pow((A[2] - B[2]),2));

Console.Write($"Расстояние между точками = {c}");

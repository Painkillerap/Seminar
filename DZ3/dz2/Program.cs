/*
Задача 21
Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

System.Console.WriteLine("Введите координату x точки А: ");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату y точки А: ");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату z точки А: ");
int z1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату x точки Б: ");
int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату y точки Б: ");
int y2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату z точки Б: ");
int z2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1)));
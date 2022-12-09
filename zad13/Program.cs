/*
Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние между ними 
в 2D пространстве.

A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/
//int[] point = new int[2];
System.Console.WriteLine("Введите координату x точки А: ");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату y точки А: ");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату x точки Б: ");
int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату y точки Б: ");
int y2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)));
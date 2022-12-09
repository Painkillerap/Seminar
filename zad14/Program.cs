/*
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу квадратов чисел 
от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/
System.Console.WriteLine("Введите степень ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    System.Console.Write($"{i * i} ");
}
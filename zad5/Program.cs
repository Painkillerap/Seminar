﻿
/*
Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
	456 -> 6
	782 -> 2
*/
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write(N % 10);
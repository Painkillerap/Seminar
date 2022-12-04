/*
Напишите программу, которая выводит случайное 
трехзначное число и удаляет вторую цифру этого числа.
*/
int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int num = ((number / 100) * 10 + (number % 10));
System.Console.WriteLine(num);
string num1 = Convert.ToString(number);
System.Console.WriteLine($"{num1[0]}{num1[^1]}");

/*
int number = new Random().Next(100, 1000);
Console.WriteLine($" Рандомное число {number}");
int first = number / 100;
int second = number % 10;
string num = Convert.ToString(first) + Convert.ToString(second);
int rez = Convert.ToInt32(num);
Console.WriteLine($" Число без средней цифры {rez}");
*/
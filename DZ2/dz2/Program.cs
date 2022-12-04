/*
Задача 13: Напишите программу, которая выводит 
третью цифру заданного числа или сообщает,
 что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

System.Console.WriteLine("Введите трехзначное число: ");
string number = Console.ReadLine();

if (number.ToString().Length > 2)
{
    System.Console.WriteLine(number[2]);
}
else
{
    System.Console.WriteLine("Третьей цифры нет");
}

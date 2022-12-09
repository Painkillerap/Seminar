/*
Задача 19
Напишите программу, которая принимает на вход пятизначное 
число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
Console.WriteLine("Введите пятизначное число ");

//int N = Convert.ToInt32(Console.ReadLine());
int number = Convert.ToInt32(Console.ReadLine());
int number1=0;
string str=number.ToString();
char[] array= str.ToCharArray();
Array.Reverse(array);
str=new String(array);
number1=Convert.ToInt32(str);

if (number.ToString().Length==5 )
{
    if (number==number1)
    {
        Console.WriteLine("Число является полиндромом");
    }
    else
    {
        Console.WriteLine("Число не является  полиндромом");
    }

}
else
{
    Console.WriteLine("Число не является пятизначным");
}

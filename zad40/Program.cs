/*
Задача 69: Напишите программу, которая на вход принимает 
два числа A и B, и возводит число А в целую степень B с 
помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

Console.Clear();
int A = InputNumber("Введите число: ");
int B = InputNumber("Введите степень: ");
System.Console.WriteLine($"Число А в степени В равно: {SquareNumber(A,B)}");

int SquareNumber(int A, int B)
{
    if (B==0)
    {
        return 1;
    }
    int result=A*SquareNumber(A,B-1);
    return result;
}

int InputNumber(string str)
{
    int number;
    string text;
    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}
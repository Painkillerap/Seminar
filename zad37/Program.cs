/*
Задача 63: Задайте значение N. Напишите программу, которая выведет все 
натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/
Console.Clear();
int M = InputNumber("Введите число N: ");
Number(M);

void Number(int n)
{
    if (n==0)
    {
        return;
    }
 Number(n-1);
 System.Console.Write($" {n};");
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
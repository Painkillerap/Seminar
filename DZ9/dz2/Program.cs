/*
Задача 66: Задайте значения M и N. Напишите программу, которая 
найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Clear();
int M = InputNumber("Введите число M: ");
int N = InputNumber("Введите число N: ");
SumNumber(M, N, 0);

void SumNumber(int m, int n, int Sum)
{
    if (m > n)
    {
        System.Console.Write($" {Sum}");
        return;
    }
    Sum += (m++);
    SumNumber(m, n, Sum);

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
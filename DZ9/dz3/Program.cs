/*
Задача 68: Напишите программу вычисления функции Аккермана с
 помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
Console.Clear();
int M = InputNumber("Введите число M: ");
int N = InputNumber("Введите число N: ");
System.Console.WriteLine($"A(m,n) = {Akkerman(M,N)}");

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if ((m != 0) && (n == 0))
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
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
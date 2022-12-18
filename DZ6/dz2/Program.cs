/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.Clear();
int K1 = InputNumber("Введите число K1: ");
int B1 = InputNumber("Введите число B1: ");
int K2 = InputNumber("Введите число K2: ");
int B2 = InputNumber("Введите число B2: ");
double FuncX = FuncintersectionX(K1, B1, K2, B2);
double FuncY = FuncintersectionY(K1, B1, FuncX);
System.Console.WriteLine($"Точка пересечения прямых => ({FuncX}; {FuncY})");

int InputNumber(string str)
{
    int number;
    string text;

    while (true)
    {
        System.Console.WriteLine(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}

double FuncintersectionX(double K1, double B1, double K2, double B2)
{
    double x = (B2 - B1) / (K1 - K2);
    return x ;
}

double FuncintersectionY(double a1, double b1, double x)
{
    double y = K1 * FuncX + B1;
    return y ;
}


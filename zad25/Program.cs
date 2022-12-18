/*
Задача 40: Напишите программу,которая принимает на вход три числа и проверяет,
 может ли существовать треугольник с сторонами такой длины.
Каждая сторона треугольника, меньше суммы двух других сторон.
*/
int A = InputNumber("Введите число A: ");
int B = InputNumber("Введите число B: ");
int C = InputNumber("Введите число C: ");
Func(A,B,C);


void Func(int A, int B, int C)
{
    if ((A > (B + C)) || (B > (A + C)) || (C > (B + A)))
        System.Console.WriteLine("Треугольник с такими сторонами не существует");
    else
        System.Console.WriteLine("Треугольник с такими сторонами существует");
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

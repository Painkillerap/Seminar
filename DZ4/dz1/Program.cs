/*
Задача 25: Напишите цикл, который принимает на вход 
два числа (A и B) и возводит число A в натуральную
 степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/
int A =inputNumber("Введите число A: ");
int B = inputNumber("Введите число B: ");
int result = Degree(A,B);

System.Console.WriteLine($"Число {A} в степени {B} = {result}");

int Degree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    return result;
}

int inputNumber(string str)
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
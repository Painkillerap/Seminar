/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1 
Если N = 7 -> 0 1 1 2 3 5 8
*/

Console.Clear();
int a = 0, b = 1;
int temp;
int A = InputNumber("Введите число: ");

for (int i = 0; i < A; i++)
{
    System.Console.Write(a + " ");
    temp = a;
    a = b;
    b = temp + b;
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

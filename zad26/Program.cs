/* Задача 42: Напишите программу.которая будет преобразовывать десятичное 
число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

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

void ConvDecInBin(int A)
/*
{
    if (A / 2 != 0)
        ConvDecInBin(A / 2);
    System.Console.Write(A % 2);
}
*/
{
    if (A <= 0) return;
    ConvDecInBin(A / 2);
    System.Console.Write(A % 2);
}



int A = InputNumber("Введите число для конвертации: ");
ConvDecInBin(A);
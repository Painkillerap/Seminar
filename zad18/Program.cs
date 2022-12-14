/*
Напишите программу, которая выводит массив из 8 элементов, заполненный 
нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/
int arrayLenght=inputNumber();

int [] array=Auto(arrayLenght);
System.Console.WriteLine(string.Join(" | ", array));
//foreach (var item in array)
//{
//    System.Console.Write(item);
//}
int[] Auto(int len)
{   
    int[] array=new int[len];
    Random rand=new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=rand.Next(0,2);
    }
    return array;
}

int inputNumber()
{
    int number;
    string text;

    while (true)
    {
        System.Console.WriteLine("Введите размер массива: ");
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}
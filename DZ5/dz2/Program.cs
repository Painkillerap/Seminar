/*
Задача 36: Задайте одномерный массив, заполненный 
случайными числами. Найдите сумму элементов, стоящих 
на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/
const int SIZE = 10;
const int LEFT_RANGE = 10;
const int RIGHT_RANGE = 100;
int [] arr=FillArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGHT_RANGE);
int N=SumOdd(arr);
printArray(arr);
System.Console.WriteLine($"Сумма элементов стоящих на нечетных позиция равна: {N}");

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    int[] tempArr = new int[size];
    Random rand = new Random();
    for(int i = 0; i < tempArr.Length; i++)
    {
        tempArr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return tempArr;
}

int[] SumOdd(int[] arr)
{
    int [] myArray=new int[arr.Length];
    int result=0;
    for(int i = 1; i < arr.Length; i++)
    if (i%2!=0)
    {
        result+=myArray[i];
    }
    return result;
}

void printArray(int[]arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}
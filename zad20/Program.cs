/*
Решение в группах задач:
Задача 32: Напишите программу замена элементов массива: положительные
 элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 
Задача 33: Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да
*/

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

void CHArrNumber(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i]*=-1;
    }
}
const int SIZE = 5;
const int LEFT_RANGE = -9;
const int RIGHT_RANGE = 9;

int[] arr = FillArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGHT_RANGE);
System.Console.WriteLine("[" + string.Join(", ", arr) + "]");

CHArrNumber(arr);
System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
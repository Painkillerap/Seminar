/*
Задача 35: Задайте одномерный массив из 123 случайных чисел.
 Найдите количество элементов массива, значения которых 
 лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём 
решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

const int SIZE = 123;
const int LEFT_RANGE = -100;
const int RIGHT_RANGE = 100;
int [] arr=FillArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGHT_RANGE);
int N=Number(arr);
System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
System.Console.WriteLine(N);

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

int Number(int[] arr)
{
    int count=0;
    for(int i = 0; i < arr.Length; i++)
    if(10<arr[i]&&arr[i]<99)
    {
       count++; 
    }
       
    return count;
}
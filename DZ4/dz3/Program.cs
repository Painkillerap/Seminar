/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/
const int SIZE = 8;
const int LEFT_RANGE = -10;
const int RIGHT_RANGE = 10;
int [] arr=FillArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGHT_RANGE);
printArray(arr);
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
void printArray(int[]arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}
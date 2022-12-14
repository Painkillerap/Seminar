/*
Задача 37: Найдите произведение пар чисел в одномерном 
массиве. Парой считаем первый и последний элемент, второй
 и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/
//tempArr[i] = Math.Round(rand.Next(-10, 11) + rand.NextDouble(), 3)


const int SIZE = 9;
const int LEFT_RANGE = -10;
const int RIGHT_RANGE = 10;
int [] arr=FillArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGHT_RANGE);
printArray(arr);
printArray(GetSum(arr));

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

int[] GetSum(int[] arr)
{
    int [] myArray=new int[(arr.Length/2) + (arr.Length%2)];
    for(int i = 0; i < arr.Length/2; i++)
    {
      myArray[i] = arr[i]*arr[(arr.Length-1)-i];
    }
    if (arr.Length%2!=0)
        myArray[^1]=arr[arr.Length/2];
       
    return myArray;
}

void printArray(int[]arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}
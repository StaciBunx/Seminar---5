//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

using System;
using static System.Console;
Clear();


int [] myArray = {3,7,22,2,78};
WriteLine($"[{String.Join(",",myArray)}]");
WriteLine(GetDiff(myArray));

int GetDiff(int[] array)
{
    int max = array[0];
    int min = array[0];
    int i = 1;
    int diff = 0;

    for (i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    diff = max - min;
    return diff;
}

//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

using System;
using static System.Console;
Clear();

int[] newArray = GetRandomArray(4, 0, 100);
WriteLine($"[{String.Join(",", newArray)}]");
WriteLine($"{SumOfNotEvenInd(newArray)}");

int SumOfNotEvenInd(int[] collection)
{
    int answer = 0;

    for (int index = 1; index < collection.Length; index += 2)
    {
        answer += collection[index];
    }
    return answer;
}

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
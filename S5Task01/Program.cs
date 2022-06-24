//Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

using System;
using static System.Console;
Clear();

int[] array = GetRandomArray(4);
WriteLine($"[{String.Join(",", array)}]");
WriteLine ($"{FindEven(array)}");


int[] GetRandomArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(100, 999);
    }
    return result;
}

int FindEven(int[] collection)
{
    int count = 0;
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
﻿//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

void FillArray(int [] array)
{
Random rnd = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(9);
} 
}

void PrintArray(int [] array)
{

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
} 
}
int[] arr = new int[8];

FillArray(arr);
PrintArray(arr);

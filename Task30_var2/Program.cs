﻿// // напишите программу, которая выводит массив из 8 элементов, заполненный 0 и 1 в случайном порядке


static void Task30_var2()
{

    Random random = new Random(); //массив состоит из 0 и 1, поэтому в скобках при Next  пишем от 0 (включается) до 2 (не включается) 
    int [] arr = new int [8]; // создаем новый массив на 8 элементов
    for (int i = 0; i < arr.Length; i++)
    {
    arr [i] = random.Next(0,2);
    // Console.Write(arr[i] + " ");
    }

    string array = String.Join(" ",arr);
    Console.Write(array);
}

Task30_var2();


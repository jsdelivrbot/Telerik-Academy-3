﻿using System;

/*  Problem 1. Allocate array
    Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
    Print the obtained array on the console.
 */

class AllocateArray
{
    static void Main()
    {
        int[] arrayOfNumbers = new int[20];

        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            arrayOfNumbers[i] = i * 5;
        }

        string numbers = string.Join(", ", arrayOfNumbers);
        Console.WriteLine(numbers);
    }
}
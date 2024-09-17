﻿namespace Question9;

class Program
{
    static void DisplayArray(int[] array)
    {
        foreach (int currentNumber in array)
        {
            System.Console.WriteLine(currentNumber);
        }
    }

    static int[] GetPositiveNumbers(int[] array)
    {
        int count = 0;
        foreach (int currentNumber in array)
        {
            if (currentNumber > 0)
            {
                count++;

            }
        }
        int[] positiveNumbers = new int[count];
        int index = 0;
        foreach (int currentNumber in array)
        {
            if (currentNumber > 0)
            {
                positiveNumbers[index] = currentNumber;
                index++;
            }
        }
        Array.Reverse(positiveNumbers);
        return positiveNumbers;
    }


    static void Main(string[] args)
    {
        int[] array = { 3, -6, -7, 8, 4, -6, -9, 2 };
        DisplayArray(array);
        int[] positiveNumbers = GetPositiveNumbers(array);

        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                array[i] = positiveNumbers[index];
                index++;
            }
        }
        System.Console.WriteLine("*********************");
        DisplayArray(array);


    }
}
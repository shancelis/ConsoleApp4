
using System;  
                      
public class DuplicateElement
{
    public static void Main()
    {
        //Initialize array   
        int[] arr = new int[] { 5, 1, 4, 6, 7, 3, 5, 7, 3 };

        Console.WriteLine("Duplicate elements in given array: ");
        //Searches for duplicate element  
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                    Console.WriteLine(arr[j]);
            }
        }
    }
}
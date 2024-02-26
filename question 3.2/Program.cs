// See https://aka.ms/new-console-template for more information
Console.Write("Enter the size of the array: ");
int size = Convert.ToInt32(Console.ReadLine());

// Declare an array with the specified size
using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1,5,-8,-6 };
        CheckIfBalanced(arr);
    }

    static void CheckIfBalanced(int[] arr)
    {
        int counter = 0;

        for (int i = 0; i < arr.Length; i = i + 1)
        {
            if (arr[i] == 0)
            {
                Console.WriteLine("unbalanced");
                return;
            }
            else if (arr[i] > 0)
            {
                counter++;
            }
            else
            {
                counter--;
            }
        }

        if (counter == 0)
        {
            Console.WriteLine("balanced");
        }
        else
        {
            Console.WriteLine("not balanced");
        }
    }
}






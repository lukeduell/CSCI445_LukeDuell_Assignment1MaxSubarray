/* Luke Duell
 * Instructor: Dr. Alnaji
 * CSCI 445: Design and Analysis of Algorithm
 * Assignment 1
 * Description: This program uses the function MaxSubArray
 *              to find the sum of the max subarray from
 *              the given array. This is done by going through
 *              each element in the array, adding it to max_floor,
 *              and comparing the smallest value to the floor or zero.
 *              That min value is then added to the input to find the
 *              resulting max sub.
 *              
 */

using System;

class WritetoConsole
{
    static int MaxSubArray(int[] input)
    {
        int size = input.Length;
        int max_floor = 0;

        //setting the min value of the input to maxsub
        int maxsub = int.MinValue;

        for (int i = 0; i < size; i++)
        {
            //given the size of the array the input is being added to the previous
            max_floor = max_floor + input[i];

            //if the min value is less than zero, set it equal to 0 avoiding negatives
            if (maxsub < max_floor)
                maxsub = max_floor;

            //if maxfloor is less than zero set it to zero 
            if (max_floor < 0)
                max_floor = 0;
        }

        return maxsub;
    }
    static void Main()
    {
        int[] input = {-5, -4, -3,  -2, -1, 0, 3, 6, 2, -1, -10, 10};
        
        //printing the output of the function. Result should be 11
        Console.WriteLine($"The max subarray is {MaxSubArray(input)}");
    }
}
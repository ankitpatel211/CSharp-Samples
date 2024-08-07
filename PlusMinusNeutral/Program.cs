﻿class Result
{
    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        int n = arr.Count;  
        var categoryOfElements = numCnt(arr);
        int posNumCnt = categoryOfElements[0];
        int negNumCnt = categoryOfElements[1];
        int zeroNumCnt = categoryOfElements[2];
        Console.WriteLine("Probability of Positive Numbers: " + ((float)posNumCnt / n).ToString("N32"));
        Console.WriteLine("Probability of Negative Numbers: " + ((float)negNumCnt / n).ToString("N32"));
        Console.WriteLine("Probability of Number of Zeros: " + ((float)zeroNumCnt / n).ToString("N32"));
    }

    public static int[] numCnt(List<int> arr)
    {
        int posEleCnt = 0;
        int negEleCnt = 0;
        int zeroEleCnt = 0;
        foreach (int a in arr)
        {
            if (a > 0)
            {
                posEleCnt += 1;
            }
            else if (a < 0)
            {
                negEleCnt += 1;
            }
            else
            {
                zeroEleCnt += 1;
            }
        }
        int[] categoryOfElements =
         { posEleCnt, negEleCnt, zeroEleCnt };
        return categoryOfElements;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of integers horizontally separated by a blank space:");
        List<int> arr = Console.ReadLine().TrimEnd()
        .Split(' ').ToList()
        .Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        Result.plusMinus(arr);
    }
}
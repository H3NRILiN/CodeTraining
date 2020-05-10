using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array101_1 : MonoBehaviour
{
    private void Start()
    {

        var ans1 = SortedSquares(new int[] { -4, -1, 0, 3, 10 });
        foreach (var ans in ans1)
        {
            Debug.Log(ans);
        }
    }

    //[12,345,2,6,7896]
    public int FindNumbers(int[] nums)
    {
        int temp = 0;
        int digits = 0;
        int even = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            digits = 0;
            temp = nums[i];
            while (temp > 0)
            {
                digits++;
                temp /= 10;
            }

            if (digits % 2 == 0)
                even++;
        }

        return even;
    }

    public int[] SortedSquares(int[] A)
    {
        for (int i = 0; i < A.Length; i++)
        {
            A[i] *= A[i];

        }
        Array.Sort(A);
        return A;
    }

}

// public abstract class Solution<T>
// {
//     public T m_RunInput { get; set; }
//     public abstract void Run();
// }

// public class Solution02 : Solution<int[]>
// {
//     public int[] m_RunInput;
//     public override void Run()
//     {
//         FindNumbers([m_RunInput]);
//     }

//     public int FindNumbers(int[] nums)
//     {
//         int temp = nums[0];
//         while (temp > 0)
//         {

//         }
//     }
// }

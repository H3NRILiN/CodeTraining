using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array101_2 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Solution solution = new Solution();
        //solution.Merge(new int[] { 4, 5, 6, 0, 0, 0 }, 3, new int[] { 1, 2, 3 }, 3);
        //solution.DuplicateZeros(new int[] { 1, 0, 2, 3, 0, 4, 5, 0 });
        solution.RemoveElement(new int[] { 0, 1, 2, 2, 3, 0, 4, 0 }, 2);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public class Solution
    {
        public void DuplicateZeros(int[] arr)
        {
            DebugLogArray(arr, "輸入");
            List<int> result = new List<int>();
            for (int x = 0; x < arr.Length; x++)
            {
                result.Add(arr[x]);
                if (arr[x] == 0)
                {
                    result.Add(arr[x]);
                }

                DebugLogArray(result.ToArray(), "過程1");

                if (result.Count == arr.Length)
                    break;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = result[i];
                DebugLogArray(arr, "過程2");
            }
            // for (int x = 0; x < arr.Length; x++)
            // {
            //     if (arr[x] == 0)
            //     {
            //         for (int y = arr.Length - 1; y >= x; y--)
            //         {
            //             if (y + 1 < arr.Length)
            //                 arr[y + 1] = arr[y];
            //         }
            //         x++;
            //     }
            // }
        }

        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            DebugLogArray(nums1, "輸入");
            DebugLogArray(nums2, "輸入");
            //最佳版
            int i = m - 1;
            int j = n - 1;
            int k = m + n - 1;
            while (i >= 0 && j >= 0)
            {
                if (nums1[i] > nums2[j])
                {
                    nums1[k] = nums1[i];
                    k--;
                    i--;
                }
                else
                {
                    nums1[k] = nums2[j];
                    k--;
                    j--;
                }
                DebugLogArray(nums1, "過程1");
            }

            while (j >= 0)
            {
                nums1[k] = nums2[j];
                k--;
                j--;
                DebugLogArray(nums1, "過程2");
            }
            DebugLogArray(nums1, "結果");
            //正確版1
            // int nums2Index = 0;
            // for (int x = m; x < nums1.Length; x++)
            // {
            //     if (nums2Index < nums2.Length)
            //     {
            //         nums1[x] = nums2[nums2Index];
            //         nums2Index++;
            //     }
            // }
            // // int temp = 0;
            // for (int x = 0; x < nums1.Length; x++)
            // {
            //     if (x + 1 >= nums1.Length)
            //         continue;

            //     if (nums1[x] > nums1[x + 1])
            //     {
            //         int temp = nums1[x + 1];
            //         nums1[x + 1] = nums1[x];
            //         nums1[x] = temp;
            //         x = -1;
            //     }
            // }
            //慢速版
            //     DebugLogArray(nums1, "輸入");
            //     DebugLogArray(nums2, "輸入");
            //     int nums2Index = 0;
            //     bool readyToSort = false;
            //     for (int x = 0; x < nums1.Length; x++)
            //     {
            //         if (!readyToSort)
            //         {
            //             if (x > m - 1 && nums2Index < nums2.Length)
            //             {
            //                 nums1[x] = nums2[nums2Index];
            //                 nums2Index++;

            //                 if (nums2Index >= nums2.Length)
            //                 {
            //                     // readyToSort = true;
            //                     x = -1;
            //                 }
            //             }
            //         }
            //         else
            //         {
            //             if (x + 1 >= nums1.Length)
            //                 continue;

            //             if (nums1[x] > nums1[x + 1])
            //             {
            //                 int temp = nums1[x + 1];
            //                 nums1[x + 1] = nums1[x];
            //                 nums1[x] = temp;
            //                 x = -1;
            //             }
            //         }
            //         DebugLogArray(nums1, "輸入");
            //     }


            //     for (int x = 0; x < nums1.Length; x++)
            //     {


            //     }
            //     DebugLogArray(nums1, "輸入");


            //邏輯錯誤版
            // int nums2Index = 0;

            // for (int x = 0; x < nums1.Length; x++)
            // {
            //     if (nums2Index < nums2.Length)
            //     {
            //         if (nums1[x] == 0)
            //         {
            //             nums1[x] = nums2[nums2Index];
            //             nums2Index++;

            //             DebugLogArray(nums1, "輸入");
            //             continue;
            //         }
            //         if (nums1[x] >= nums2[nums2Index])
            //         {
            //             for (int y = nums1.Length - 1; y >= x; y--)
            //             {
            //                 if (y + 1 < nums1.Length)
            //                 {
            //                     nums1[y + 1] = nums1[y];
            //                 }
            //             }
            //             nums1[x] = nums2[nums2Index];
            //             nums2Index++;

            //         }
            //     }
            //     DebugLogArray(nums1, "輸入");
            // }

            // DebugLogArray(nums1, "輸入");
            // DebugLogArray(nums2, "輸入");
            // Debug.Log("-----");
            // int nums2indx = 0;
            // int nums2Curr = 0;
            // for (int x = 0; x < nums1.Length; x++)
            // {
            //     Debug.Log("-----");
            //     if (nums2indx < nums2.Length)
            //     {
            //         //Debug.Log(nums2indx + " " + nums2[nums2indx]);
            //         nums2Curr = nums2[nums2indx];
            //         Debug.Log(" nums2Curr:" + nums2Curr);
            //         if (nums1[x] == 0)
            //         {
            //             nums1[x] = nums2Curr;
            //             nums2indx++;

            //             DebugLogArray(nums1, "輸入");
            //             continue;
            //         }

            //         if (nums2Curr == nums1[x])
            //         {
            //             for (int y = nums1.Length - 1; y >= x + 1; y--)
            //             {
            //                 if (y + 1 < nums1.Length)
            //                 {
            //                     nums1[y + 1] = nums1[y];
            //                 }
            //             }
            //             nums1[x + 1] = 0;
            //         }
            //         DebugLogArray(nums1, "輸入");
            //     }
            // }
            // Debug.Log("-----");
            // DebugLogArray(nums1, "輸出");
            // DebugLogArray(nums2, "輸出");



        }

        public int RemoveElement(int[] nums, int val)
        {
            //普通版
            // DebugLogArray(nums, "輸入");
            // int length = nums.Length;
            // //使用length原因, 若最後一數為val, 處理後會變成倒數第一與第二都為val, 這樣而會造成無限loop
            // for (int x = 0; x < length; x++)
            // {
            //     if (nums[x] == val)
            //     {
            //         for (int y = x + 1; y < length; y++)
            //         {
            //             nums[y - 1] = nums[y];
            //             DebugLogArray(nums, "裡過程");
            //         }
            //         length--;
            //         x = x - 1;
            //     }
            //     //DebugLogArray(nums, length, "外過程");
            // }
            // return length;

            //最佳版
            var count = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[count] = nums[i];
                    count++;
                }
                DebugLogArray(nums, "裡過程");
            }
            DebugLogArray(nums, count);
            return count;
        }

        public int RemoveDuplicates(int[] nums)
        {
            int length = nums.Length;
            return length;
        }

        private static void DebugLogArray(int[] nums1, string prefix = "", string suffix = "")
        {
            string log = prefix + " [";
            foreach (var num in nums1)
            {
                log += num.ToString() + ",";
            }
            log += "] " + suffix;
            Debug.Log(log);
        }
        private static void DebugLogArray(int[] nums1, int customLength, string prefix = "", string suffix = "")
        {
            string log = prefix + " [";
            for (int i = 0; i < customLength; i++)
            {
                int num = nums1[i];
                log += num.ToString() + ",";
            }
            log += "] " + suffix;
            Debug.Log(log);
        }
    }
}

using System.Runtime.InteropServices;

namespace Leet.Solutions;

public class Solutions
{
    /// <summary>
    /// Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]). 
    /// Return the running sum of nums.
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public static int[] RunningSum(int[] nums)
    {
        var result = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            //result[i] = nums[0..(i + 1)].Sum(); //this is simpler IMO

            var sum = 0;
            for (var j = 0; j < i + 1; j++)
            {
                sum += nums[j];
            }
            result[i] = sum;
        }
        return result;
    }

    /// <summary>
    /// Given an array of integers nums, calculate the pivot index of this array.
    /// The pivot index is the index where the sum of all the numbers strictly to the left of the index is equal to the sum of all the numbers strictly to the index's right.
    /// If the index is on the left edge of the array, then the left sum is 0 because there are no elements to the left.This also applies to the right edge of the array.
    /// Return the leftmost pivot index.If no such index exists, return -1.
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public static int PivotIndex(int[] nums)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            var leftSum = nums[0..i].Sum();
            var rightSum = nums[(i + 1)..nums.Length].Sum();

            if (leftSum == rightSum)
            {
                return i;
            }
        }

        return -1;
    }

    /// <summary>
    /// Given two strings s and t, determine if they are isomorphic.
    /// Two strings s and t are isomorphic if the characters in s can be replaced to get t.
    /// All occurrences of a character must be replaced with another character while preserving the order of characters.No two characters may map to the same character, but a character may map to itself.
    /// </summary>
    /// <param name="s"></param>
    /// <param name="t"></param>
    /// <returns></returns>
    public static bool IsIsomorphic(string s, string t)
    {
        var mappings = new Dictionary<char, char>();
        for (var i = 0; i < s.Length; i++)
        {
            var charS = s[i];
            var charT = t[i];

            if (mappings.ContainsKey(charS))
            {
                if (mappings[charS] != charT) { return false; }
            }
            else
            {
                if (mappings.ContainsValue(charT))
                {
                    return false;
                }
                mappings.Add(charS, charT);
            }

        }
        return true;
    }
}
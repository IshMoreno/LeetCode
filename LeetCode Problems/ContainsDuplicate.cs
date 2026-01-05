/* Given an integer array nums, return true if any value appears at least twice 
 * in the array, and return false if every element is distinct.
 */

/* Edge Cases:
 * 1. Empty array: An empty array should return false since there are no elements to compare.
 * 2. Single element array: An array with one element should return false since there are no duplicates.
 * 3. All elements are the same: An array where all elements are identical should return true.
 * 4. Negative numbers: The array may contain negative integers, which should be handled correctly.
 * 5. Large arrays: The solution should be efficient enough to handle large arrays within reasonable time limits.
 * 6. Mixed positive and negative numbers: The array may contain both positive and negative integers.
 * 7. Large range of values: The integers in the array can be very large or very small, 
 *    testing the solution's ability to handle a wide range of values.
 */
my_List = [1,2,3,1]

namespace ContainsDuplicate
{
    class Solution:
        def containsDuplicate(self, nums: List[int]) -> bool:
            hashset = set()
            for num in nums:
                if num in hashset:
                    return True  # Duplicate found
                hashset.add(num)
            return False  # No duplicates found
}

// Time Complexity: O(n), where n is the number of elements in the array.
// Space Complexity: O(n) in the worst case, if all elements are distinct.

// Alternative Brute Force Approach
namespace ContainsDuplicate
{
    class Solution :
        def containsDuplicate(self, nums: List[int]) -> bool:
            for i in range(len(nums)):
                for j in range(i + 1, len(nums)):
                    if nums[i] == nums[j]:
                        return True  # Duplicate found
            return False  # No duplicates found
}

// Time Complexity: O(n^2), where n is the number of elements in the array.
// Space Complexity: O(1) as no additional space is used.
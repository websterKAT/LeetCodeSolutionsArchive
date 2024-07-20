public class Solution {
    public int RemoveElement(int[] nums, int val) {
        var array = new int[nums.Length];
        var count = 0;

        for (var i = 0; i < nums.Length; i++) 
        {
            if (nums[i] != val) 
            {
                array[count++] = nums[i];
            }
        }

        for (var i = 0; i < array.Length; i++) 
        {
            nums[i] = array[i];
        }

        return count;
    }
}
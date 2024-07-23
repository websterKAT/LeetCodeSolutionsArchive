public class Solution {
    public void Rotate(int[] nums, int k) {
        int z =  k % nums.Length;
        int[] newArr = new int[z];
        int startIndex = nums.Length-z;
        int count = 0;
        while(startIndex < nums.Length){
            newArr[count] = nums[startIndex];
            count++;
            startIndex++;
        }

        int newSi =  nums.Length-z-1;
        count = 0;
        while(newSi >= 0){
            nums[nums.Length-1-count] = nums[newSi];
            newSi--;
            count++;
        } 

        for(int i =0; i < z; i++){
            nums[i] = newArr[i];
        }
    }
}
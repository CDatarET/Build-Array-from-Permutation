public class Solution {
    public int[] BuildArray(int[] nums) {
        int[] ret = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++){
            ret[i] = nums[nums[i]];
        }

        return(ret);
    }
}

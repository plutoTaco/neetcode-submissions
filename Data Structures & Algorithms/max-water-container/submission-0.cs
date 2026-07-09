public class Solution {
    public int MaxArea(int[] height) {
        int maxArea = 0;
        int left = 0;
        int right = height.Length-1;

        while(left<right){
            int currentArea = Math.Min(height[left],height[right])*(right-left);
            maxArea = Math.Max(currentArea, maxArea);
            if(height[left]<height[right]){
                left++;
            }
            else{
                right--;
            }
        }
        return maxArea;
    }
}
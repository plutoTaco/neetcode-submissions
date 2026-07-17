public class Solution {
    public int LengthOfLongestSubstring(string s) {
        
        int left = 0;
        int maxLength = 0;
        HashSet<char> seen = new HashSet<char>();
        int windowlength = 0;

        for(int right=0; right<s.Length; right++)
        {
            while(seen.Contains(s[right])){
                seen.Remove(s[left]);
                left++;
            }
            seen.Add(s[right]);
            windowlength = right - left+1;
            maxLength = Math.Max(windowlength, maxLength);
        }
        return maxLength;
    }
}

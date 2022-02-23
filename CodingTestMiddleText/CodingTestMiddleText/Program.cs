using System;
public class Solution
{
    public static void Main()
    {
        Solution solution = new Solution(); 
    }
    public string solution(string s)
    {
        string answer = "";
        if (s.Length < 3)
        {
            answer = s;
        }
        else
        {
            int nLength = (int)s.Length / 2;
            if (s.Length % 2 == 0)
            {
                answer = s[nLength - 1].ToString() + s[nLength].ToString();
            }
            else
            {
                answer = s[nLength].ToString();
            }
        }
        return answer;
    }
}
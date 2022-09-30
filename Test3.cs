namespace Test
{
    using System;

    public class Test3
    {
        public bool isPalindrome(string str) {
            int strLength = str.Length;
            if (strLength < 2) {
                return true;
            }

            if (str[0] == str[strLength-1]) {
                return isPalindrome(str.Substring(1, strLength - 2));
            } else {
                return false;
            }
        }
    }
}
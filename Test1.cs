
namespace Test {
    using System;
    using System.Text;

    static class Util { 
        public static void staircase(int n) {
            for(int i = 1; i < n + 1; i++) {
                Console.WriteLine(amountOfTabs(n - i) + amountOfTags(i));
            }
        }

        public static void staircaseImprove1(int n) {
            string spaces = amountOfTabs(n);
            string tags = amountOfTags(n);

            for (int i = n - 1; i >= 0; i--) {
                Console.WriteLine(spaces.Substring(0, i) + tags.Substring(i));
            }
        }

        public static void staircaseImprove2(int n) {
            char[] spaces = amountOfTabsChar(n);

            for (int i = n - 1; i >= 0; i--) {
                spaces[i] = '#'; 
                Console.WriteLine(spaces);
            }
        }

        static string amountOfTags(int n) {
            string t = "";
            for(int j = 0; j < n; j++) {
                t += "#";
            }
            return t;
        }

        static string amountOfTabs(int n) {
            string t = "";
            for(int i = 0; i < n; i++) {
                t += " ";
            }
            return t;
        }

        static char[] amountOfTabsChar(int n) {
            char[] t = new char[n];
            for(int j = 0; j < n; j++) {
                t[j] = ' ';
            }
            return t;
        }
    }
}

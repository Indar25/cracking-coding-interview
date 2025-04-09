namespace DSA.String
{
    internal class StringProblem
    {
        //https://leetcode.com/problems/permutation-in-string/
        public bool GetPermutations(string s1, string s2)
        {
            int lenS1 = s1.Length;
            int lenS2 = s2.Length;
            if (lenS1 > lenS2)
                return false;

            int[] freqS1 = new int[26];
            int[] freqS2 = new int[26];

            for (int i = 0; i < lenS1; i++)
            {
                freqS1[s1[i] - 'a']++;
            }

            for (int i = 0; i < lenS1; i++)
            {
                freqS2[s2[i] - 'a']++;
            }
            if (AreEqual(freqS1, freqS2))
                return true;

            for (int i = lenS1; i < lenS2; i++)
            {
                freqS2[s2[i] - 'a']++;
                freqS2[s2[i - lenS1] - 'a']--;

                if (AreEqual(freqS1, freqS2))
                    return true;
            }
            return false;

        }
        private bool AreEqual(int[] freqS1, int[] freqS2)
        {
            for (int i = 0; i < 26; i++)
            {
                if (freqS1[i] != freqS2[i])
                    return false;
            }
            return true;
        }

        //Given a string, write a method to determine if it has all unique characters — meaning no character appears more than once.
        public bool IsUnique(string str)
        {
            int[] arr = new int[128];
            foreach (char c in str)
            {
                arr[c]++;
                if (arr[c] > 1)
                    return false;
            }
            return true;
        }
        //Check Permutation: Given two strings, write a method to decide if one is a permutation of the other.

        public bool IsPermutation(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;

            int[] arr = new int[128]; //ASCII characters (0–127)
            foreach (char c in str1)
            {
                arr[c]++;
            }

            foreach (char c in str2)
            {
                arr[c]--;
                if (arr[c] < 0)
                    return false;
            }
            return true;
        }
        public string URLify(char[] str, int trueLength)
        {
            int spaceCount = 0;

            for (int i = 0; i < trueLength; i++)
            {
                if (str[i] == ' ')
                    spaceCount++;
            }

            int index = trueLength + spaceCount * 2;

            if (trueLength < str.Length)
                str[trueLength] = '\0';

            for (int i = trueLength - 1; i >= 0; i--)
            {
                if (str[i] == ' ')
                {
                    str[index - 1] = '0';
                    str[index - 2] = '2';
                    str[index - 3] = '%';
                    index -= 3;
                }
                else
                {
                    str[index - 1] = str[i];
                    index--;
                }
            }

            return new string(str).TrimEnd('\0');
        }
        /*
        Palindrome Permutation: Given a string, write a function to check if it is a permutation of a palindrome.
        A palindrome is a word or phrase that is the same forwards and backwards.
        A permutationis a rearrangement of letters.The palindrome does not need to be limited to just dictionary words.
        */

        public bool IsPalindromePermutation(string input)
        {
            input = input.ToLower();

            int[] count = new int[128];

            foreach (char s in input)
            {
                if (s != ' ')
                    count[s]++;
            }
            bool foundOdd = false;

            foreach (int val in count)
            {
                if (val % 2 == 1)
                {
                    if (!foundOdd)
                        return false;

                    foundOdd = true;
                }
            }

            return true;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace HomeWork5
{
    static class Message
    {
        static public string WordsShorterThan(string str,int n)
        {
            string[] words = Regex.Split(str, @"(?<=[\.!\?])\s+");
            StringBuilder newStr = new StringBuilder();
            foreach (string word in words)
            {
                if (word.Length <= n)
                {
                    newStr.Append(word + "  ");
                }
            }
            return newStr.ToString();
        } 

        static public string DeleteAllWordsWith(string str,char ending)
        {
            string[] words = Regex.Split(str, @"(?<=[\.!\?])\s+");
            StringBuilder newStr = new StringBuilder();
            foreach (string word in words)
            {
                if (word[word.Length-1] != ending)
                {
                    newStr.Append(word + "  ");
                }
            }
            return newStr.ToString();
        }

        static public string LongestWord(string str)
        {
            string[] words = Regex.Split(str, @"(?<=[\.!\?])\s+");
            int index = 0,length = 0;
            for (int i = 0; i< words.Length; i++)
            {
                if (words[i].Length > length)
                {
                    index = i;
                    length = words[i].Length;
                }
            }
            return words[index];
        }

        static public string AllLongestWord(string str)
        {
            string[] words = Regex.Split(str, @"(?<=[\.!\?])\s+");
           List<int> indexes = new List<int>(); 
            int length = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > length)
                {
                    indexes.Clear();
                    indexes.Add(i);
                    length = words[i].Length;
                }else if(words[i].Length == length)
                {
                    indexes.Add(i);
                }
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < indexes.Count; i++)
            {
                sb.Append(words[indexes[i]] + "  ");
            }
            return sb.ToString();
        }
    }
}

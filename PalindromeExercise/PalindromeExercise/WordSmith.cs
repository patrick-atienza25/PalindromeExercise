using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            if (word.SequenceEqual(word.Reverse()))
            {
                return true;
            }
            else
            {
                return false;
            }
            //var reversedWord = "";

            //for(var i = word.Length -1; i >= 0; i--)
            //{
            //    reversedWord += word.ToLower();
            //}
            //if (reversedWord == word.ToLower())
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }
    }
}

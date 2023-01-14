using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            var w = word.ToCharArray();
            Array.Reverse(w);
            return (word == new string(w));
        }
    }
}

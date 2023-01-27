using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if(vals.Contains(false))
            { 
                return true; 
            } 
            else
            { return false; }
                                    //throw new NotImplementedException();
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null) { return false; }
            var odds = numbers.Where(x => x % 2 != 0);
            var sum = odds.Sum();
            if(sum % 2 != 0) { return true; }
            return false;

                                    //throw new NotImplementedException();
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit))
               { return true;  }
            return false;
                                    //throw new NotImplementedException();
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.First();
                                    //throw new NotImplementedException();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
                                    //throw new NotImplementedException();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0) { return 0; }
            if (dividend == 0) { return 0; }
            return dividend / divisor;
        }                           //throw new NotImplementedException();

        public int LastMinusFirst(int[] nums)
        {
            var last = nums.Last();
            var first = nums.First();
            return last - first;
                                    //throw new NotImplementedException();
        }

        public int[] GetOddsBelow100()
        {
           var odds = new List<int>();
            for (var i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    odds.Add(i);
                }
            } 
            return odds.ToArray();
                                    //throw new NotImplementedException();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for(var i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }   
               
            //throw new NotImplementedException();
        }
    }
}

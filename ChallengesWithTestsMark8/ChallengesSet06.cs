using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool containsWord = false;
            if(string.Equals(words, null) || words.Contains(null))
            {
                return false;
            }
            if(ignoreCase == true)
            {
                word = word.ToLower();
                List<string> lowercase = words.Select(x => x.ToLower()).ToList();
                containsWord = lowercase.Contains(word);
            }
            else if(ignoreCase == false)
            {
                containsWord= words.Contains(word);
            }
            return containsWord;
            //throw new NotImplementedException();
        }

        public bool IsPrimeNumber(int num)
        {
            var isPrime = false;
            if(num >= 0) 
            {
                if(num % 2 != 0 && num % 3 != 0)
                {
                    isPrime = true;
                }
            }
            if(num == 2 || num == 3)
            {
                isPrime = true;
            }
            if(num == 1)
            {
                isPrime = false;
            }
            return isPrime;
            //throw new NotImplementedException();
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;
            bool uIndex;
            for(var i = 0; i < str.Length; i++)
            {
                uIndex = true;
                for(var j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        uIndex = false;
                    }
                }
                if(uIndex == true)
                {
                    index = i;
                }
            }
            return index;
            //throw new NotImplementedException();
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            var count = 0;
            for(var i = 0; i < numbers.Length; i++) 
            {
                var currentCount = 1;
                for(var j = i + 1; j < numbers.Length; j++) 
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }
                    currentCount++;

                }
                if(currentCount > count)
                {
                    count = currentCount;
                }
            }
            return count;
            //throw new NotImplementedException();
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
           List<double> result = new List<double>();
            if(elements == null || n <= 0 || n > elements.Count)
            {
                return result.ToArray();
            }
            for (var i = n-1; i < elements.Count; i+= n) 
            {
                result.Add(elements[i]);
            }
            return result.ToArray();
            //throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            startNumber++;
            while (startNumber % n != 0)
            {
                startNumber++;
            }
            return startNumber;
            //throw new NotImplementedException();
            //return ((startNumber / n) + 1) * n;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (var i = 0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }
            }
            //throw new NotImplementedException();
            //businesses.Where(x => x.TotalRevenue == 0).ToList().ForEach(x => x.Name = "CLOSED");
        }

        public bool IsAscendingOrder(int[] numbers)
        {

            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }
            for (var i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
            }
            return true;
            //throw new NotImplementedException();


        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) { return 0; }
            var sum = 0;
            for(var i = 1; i < numbers.Length; i++)
            {
                if (numbers[i-1] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            return sum;
            //throw new NotImplementedException();
            //return numbers == null ? 0 : numbers.Skip(1).Where((item, index) => numbers[index] % 2 == 0).Sum();
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if(words==null || words.Length == 0) { return ""; }
            string sentence = "";
            foreach(var word in words)
            {
                if(word.Trim().Length > 0)
                {
                    sentence += word.Trim() + " ";
                }
            }
            if(sentence.Length == 0)
            {
                return "";
            }
            sentence = sentence.Trim();
            sentence += ".";
            return sentence;
            //throw new NotImplementedException();
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if(elements == null || elements.Count == 0) { return new double[0]; }
            var fourth = new List<double>();
            for (var i = 3; i < elements.Count; i += 4)
            {
                fourth.Add(elements[i]);
            }
            return fourth.ToArray();
            //throw new NotImplementedException();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for(var i = 0; i < nums.Length; i++)
            {
                for(var j = i +1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber) { return true; }
                }
            }
            return false;
            //throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (char.IsLetter(c))
            { return true; }
            else { return false; }
            //throw new NotImplementedException();
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            { return true; }
            else { return false; }
            //throw new NotImplementedException();
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            { return true; }
            else { return false; }
            //throw new NotImplementedException();
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            { return true; }
            else { return false; }
            //throw new NotImplementedException();
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count()==0) { return 0; }
            double min = numbers.Min();
            double max = numbers.Max();
            return min + max;


            //jeremy's:
            //return numbers?.Any() ?? false ? numbers.Min() + numbers.Max() : new double { };
            //if (numbers == null) { return 0; }
            //double min = 0;
            //double max = 0;
            //foreach (double number in numbers)
            //{
            //    if (number > max)
            //    {
            //        max = number;
            //    }
            //    if (number < min)
            //    {
            //        min = number;
            //    }
            //    if (numbers.Count() <= 1)
            //    {
            //        min = number;
            //    }
            //}
            //return min + max;



            //var nonull = numbers.Where(x => x != null);
            //var min = nonull.Min();
            //var max = nonull.Max();
            //return min + max;

            //throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else { return str2.Length; }
            //throw new NotImplementedException();
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null) { return 0; }
            var sum = numbers.Sum();
            return sum;
            
            // jeremy's:
            //var sum = 0;
            //for (var i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //return sum;

            //return (numbers == null) ? 0 : numbers.Sum();

            //var sum = numbers.Sum();
            //return sum;
            //throw new NotImplementedException();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null) { return 0; }
            var evens = numbers.Where(x => x % 2 == 0);
            return evens.Sum();



            //throw new NotImplementedException();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null) { return false; }
            var sum = numbers.Sum();
            if (sum % 2 != 0) { return true; }
            else { return false; }
            //throw new NotImplementedException();
        }

        public long CountOfPositiveOddsBelowNumber(long number) 
        {
            if (number <=0) { return 0; }
            else { return number /2; }
            
            //throw new NotImplementedException();
        }
        

        
    }
}


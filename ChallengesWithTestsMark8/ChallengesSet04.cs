using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int answer = 0;
            foreach(int number in numbers)
            {
                if(number % 2 == 0) 
                {
                    answer += number;
                }
                else
                {
                    answer -= number;
                }
            }
            return answer;
            //throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var lengths = new int[] { str1.Length, str2.Length, str3.Length, str4.Length };
            return lengths.Min();
            
            //throw new NotImplementedException();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var nums = new int[] { number1, number2, number3, number4, };
            return nums.Min();
            //throw new NotImplementedException();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
            //throw new NotImplementedException();
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 <= 0 || sideLength2 <= 0 || sideLength3 <= 0)
            {
                return false;
            }
            return sideLength1 + sideLength2 > sideLength3 && sideLength1 + sideLength3 > sideLength2 && sideLength2 + sideLength3 > sideLength1;

            //throw new NotImplementedException();
        }

        public bool IsStringANumber(string input)
        {
            double answer;
            return double.TryParse(input, out answer);
            //throw new NotImplementedException();
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var nulls = 0;
            foreach(var item in objs)
            {
                if(item == null)
                {
                    nulls++;
                }
            }
            return nulls > objs.Length / 2;
            //throw new NotImplementedException();
        }

        public double AverageEvens(int[] numbers)
        {
            double evens = 0;
            double sum = 0;
            if(numbers == null)
            {
                return 0;
            }
            foreach(var item in numbers)
            {
                if(item % 2 == 0)
                {
                    evens++;
                    sum += item;
                }
                
            }
            return evens == 0 ? 0 : sum / evens;
            //throw new NotImplementedException();
        }

        public int Factorial(int number)
        {

            var factorial = 1;
            if(number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            for(int i = number; i > 0; i--)
            {
                factorial *= i;
            }
            return factorial;
            //throw new NotImplementedException();
        }
    }
}

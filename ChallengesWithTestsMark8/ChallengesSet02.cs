using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (char.IsLetter(c))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            if (numbers.Count() == 0)
            {
                return 0;
            }

            var min = numbers.Min();
            var max = numbers.Max();
            return min + max;

        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length <= str2.Length)
            {
                return str1.Count();
            }
            else
            {
                return str2.Count();
            }
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;

            }
            return numbers.Sum(x => x);
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;

            }
           return numbers.Where(x=> x %2 == 0).Sum(x=>x);
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            var sum = numbers.Sum(x => x);
             if (sum %2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0)
            {
                return 0;
            }
            else
            {
                return number / 2;
            }
        }
    }
}

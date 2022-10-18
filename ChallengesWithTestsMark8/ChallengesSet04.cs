using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var total = 0;
            foreach (var number in numbers)
            {
               if (number % 2 == 0)
                {
                    total += number;
                }
                else
                {
                    total -= number;
                }
            }
            return total;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {

            var values = new string[] { str1, str2, str3, str4 };
            
            var answer = values
                .OrderBy(x => x.Length)
                .FirstOrDefault();
            return answer.Length;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var numbers = new int[] { number1, number2, number3, number4 };
            var answer = number1;
            foreach (var number in numbers)
            {
                if (number < answer)
                {
                    answer = number;
                }
            }
            return answer;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {

            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            var numbers = new int[] { sideLength1, sideLength2, sideLength3 };
            var hypo = sideLength1;
            foreach (var number in numbers)
            {
                if (number > hypo)
                {
                    hypo = number;
                }
            }

            var total = sideLength1 + sideLength2 + sideLength3 - hypo;
            if (total > hypo)
            {
                return true;
            }
            {
                return false;
            }
        }

        public bool IsStringANumber(string input)
        {
            var answer = false;
            var answer2 = false;
            
            if (input == null || input.Length == 0)
            {
                return answer;
            }
            foreach (var item in input)
            {
                if (char.IsDigit(item) || item == '-' || item == '.')
                {
                    answer = true;
                }
                else
                {
                    answer2 = true;
                }
            }
            if (answer2 == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var nullCount = 0;
            var numberCount = 0;
            foreach (var obj in objs)
            {
                if (obj == null)
                {
                    nullCount++;
                }
                else
                {
                    numberCount++;
                }
            }
            if (numberCount < nullCount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            
            
            var evens = 0;
            var evensCount = 0;
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    evens += number;
                    evensCount++;
                }
            }

            

            if (evensCount != 0)
            {
                double answer = (evens + 0.0000001) / evensCount;
                return Math.Round(answer, 6);
            }
            else
            {
                return 0;
            }
            
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (number == 0)
            {
                return 1;
            }
            var answer = number;
            for (int i = 1; i < number; i++)
            {
                answer *= i;
            }
            return answer;
        }
    }
}

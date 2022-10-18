using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)
                {
                    return true;
                }
                
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {

            if (numbers == null)
            {
                return false;
            }
            
            if (numbers.Sum() % 2 != 0)
            {
                return true;
            }
            return false;

        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password == null)
            {
                return false;
            }

            var a = false;
            var b = false;
            var c = false;


            foreach (var item in password)
            {
                if (char.IsUpper(item))
                {
                    a = true;
                }
                
                

            }
            foreach (var item in password)
            {
                if (char.IsLower(item))
                {
                    b = true;
                }



            }
            foreach (var item in password)
            {
                if (char.IsDigit(item))
                {
                    c = true;
                }



            }
            if (a == true && b == true && c == true)
                return true;
            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums.Last() - nums.First(); 
        }

        public int[] GetOddsBelow100()
        {

            var rng = new Random();//rng.Next(1, 100) -- switch for the one in enum range 


            var arr = Enumerable.Range(rng.Next(0,0), 100).Where(x => x % 2 != 0).ToArray();
            return arr;


        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}

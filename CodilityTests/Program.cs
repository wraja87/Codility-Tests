﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityTests
{
    class Program
    {
        static void Main(string[] args)
        {
            //var input = "213";
            //var result = solution(int.Parse(input));

            //GetHighestDigit();
            //Console.Write("Enter Input number : ");
            //var input = Console.ReadLine();
            //var result = GetLargestFamilyForInt(int.Parse(input));
            //Console.WriteLine(string.Format("Sort Result : {0}", result));

            //Solution s = new Solution();

            //int lSibling = s.solution(354);

            //Console.WriteLine(lSibling);

            //Console.ReadKey();


            //            Program obj = new Program();
            //var input = 0;
            //Console.WriteLine("define Array Length");
            //input =
            //Convert.ToInt32(Console.ReadLine());
            //int[] A = new int[input];
            //Console.WriteLine("enter array elements");
            //for (int i = 0; i < input; i++)
            //{
            //    A[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //var A = new int[] { 7, 21, 3, 42, 3, 7 };
            //var A = new int[] { 8, 25, 3, 24, 1, 17 };
            //int diff = obj.solution(A);
            //UInt32 ip = 321;
            //var res = getLargestSibling(ip);
            //AtulGaikwad(ip);
            //Console.WriteLine("Diff is {0}", res);
            //var ip = 78;
            //var res = GetHighestPower(ip);
            //Console.WriteLine(res);
            //var ip = 356;
            //var res = HighestSibling(ip);
            //int[] arry = { 7, 21, 100, 42 };
            //Console.WriteLine(MinDistance_NileshKale(arry));
            //Console.WriteLine(HighestSibling_Vrushali(23547));
            //var phoneIp = "00-44 48 5555 8361";
            //Console.WriteLine(FormatPhone_Mine(phoneIp));//004-448-555-583-61
            //phoneIp = "0 - 22 1985--324";
            //Console.WriteLine(FormatPhone_Mine(phoneIp));//022-198-53-24
            //phoneIp = "555372654";
            //Console.WriteLine(FormatPhone_Mine(phoneIp));//555-372-654
            //int highestPowerInput = 27;
            //Console.WriteLine(HighestPowerDivide(highestPowerInput));
            //int[] arr = new int[] { 9, 20, -3, -10 };
            //Console.WriteLine(GetHigeshtDeviation_Gaurav(arr));
            //var CardA = "K2Q25";
            //var CardB = "23A84";
            //Console.WriteLine(CardWar_Anant(CardA, CardB));
            var inputNumber = 12345;
            Console.WriteLine(NikhilAsarkar(inputNumber.ToString()));
            //int[] A = new int[] {8, 24, 3, 20, 1, 17 };
            //int[] A = new int[] { 7, 21, 5, 42, 3, 8 };
            //Console.WriteLine(GetHigeshtDeviation_Jayesh(A));
            Console.ReadLine();
        }
        #region Card War

        #region Anant Bandewar

        public static int CardWar_Anant(string A, string B)
        {
            int count = 0;
            char alecCard;
            char bobCard;
            if (A.Length == B.Length)
            {
                char[] alec = A.ToArray();
                char[] bob = B.ToArray();
                for (int i = 0; i < A.Length; i++)
                {
                    alecCard = alec[i];
                    bobCard = bob[i];
                    if (getCardValue(alecCard) > getCardValue(bobCard))
                    {
                        count++;
                    }
                }
            }
            else
            {

                Console.WriteLine("Invalid Input!");
            }
            return count;

        }
        public static int getCardValue(char Card)
        {
            int val = 0;

            switch (Card)
            {
                case 'A':
                    val = 100;
                    break;

                case 'K':
                    val = 99;
                    break;

                case 'Q':
                    val = 98;
                    break;

                case 'J':
                    val = 97;
                    break;

                case 'T':
                    val = 96;
                    break;
                default:
                    int number = (int)Card;
                    if (number > 1 && number < 10)
                    {
                        val = number;
                    }
                    else
                    {
                        val = 0;
                    }
                    break;
            }
            return val;

        }



        #endregion
        public static int CardWar(string A, string B)
        {
            int N = 0;
            var sanew = A.ToUpper().ToCharArray().ToArray();
            var sbnew = B.ToUpper().ToCharArray().ToArray();
            for (int i = 0; i < A.Length; i++)
            {
                N = N + winner(sanew[i], sbnew[i]);
            }
            return N;
        }

        public static int winner(char a, char b)
        {
            String nset = "23456789TJQKA";
            var posA = nset.IndexOf(a);
            var posB = nset.IndexOf(b);

            if (posA <= posB)
                return 0;
            return 1;

        }

        #endregion
        #region Average Mean Distance
        /// <summary>
        /// Gaurav Rawat
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int GetHigeshtDeviation_Gaurav(int[] A)
        {
            int result = 0;
            int prevresult = 0;
            var resultitem = 0;
            if (A.Length == 0)
            {
                return -1;
            }
            foreach (var item in A)
            {
                result = Math.Abs(item - (int)Math.Round(A.Average(), 2));
                if (result > prevresult)
                {
                    prevresult = result;
                    resultitem = item;
                }
            }
            return resultitem;
        }

        public static int GetHigeshtDeviation_Jayesh(int[] A)
        {
            int res = 1111;
            int dist = 1111;
            for (int i = 0; i < A.Count() - 1; i++)
            {
                for (int j = i; j < A.Count(); j++)
                {
                    if (i != j)
                    {
                        if (A[i] < A[j])
                        {
                            dist = A[j] - A[i];
                        }
                        else
                        {
                            dist = A[i] - A[j];
                        }
                        if (dist < res)
                            res = dist;
                    }
                }
            }

            return res;
        }
        #endregion
        #region CreativeAccounting

        public static int NikhilAsarkar(string inputNumber)
        {
            char[] characters = inputNumber.ToCharArray();
            string retVal = string.Empty;
            for (int i = 0; i < characters.Length / 2; i++)
            {
                retVal += characters[i].ToString() + (string)characters[characters.Length - i - 1].ToString();
                //if (retVal.Length == inputNumber.Length)
                //    break;
            }
            return Convert.ToInt32(retVal);
        }
        #endregion
        #region Even Sum Count

        private static void ReArrangenaive(int[] arr, int n)
        {
            // Create an auxiliary array of same size
            int[] temp = new int[n]; int i;

            /// Store result in temp[]
            for (i = 0; i < n; i++)
                temp[arr[i]] = i;

            // Copy temp back to arr[]
            for (i = 0; i < n; i++)
                arr[i] = temp[i];
        }

        #endregion
        /// <summary>
        /// Dhrivi A , ParityDegree => Find the highest power of 2 that divides N.
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        private static int HighestPowerDivide(int N)
        {
            int k = 0;
            int max = 0;
            bool IsHigest = false;
            for (int i = 0; IsHigest == false; i++)
            {
                double total = Math.Pow(2, i);
                if (N % total == 0)
                {
                    k = i;
                    //int temp = i;
                    //if (max < temp)
                    //{
                    //    max = temp;
                    //    k = i;
                    //}
                }
                else
                {
                    IsHigest =
                    true;
                }
            }
            return k;
        }

        private static string FormatPhone_Mine(string input)
        {
            StringBuilder resultPhNum = new StringBuilder();
            string phoneString = input.Replace("-", String.Empty);
            phoneString = phoneString.Replace(" ", String.Empty);
            char[] phoneArray = phoneString.ToArray();
            for (int i = 0; i < phoneArray.Length; i++)
            {
                resultPhNum.Append(phoneArray[i]);
                if (i < 2)
                    continue;
                if (phoneString.Length % 3 == 0)
                {
                    if ((i + 1) % 3 == 0)
                        resultPhNum.Append("-");
                }
                else
                {
                    if ((phoneString.Length - i) <= 4)
                    {
                        if ((phoneString.Length - i - 1) % 2 == 0)
                        {
                            resultPhNum.Append("-");
                        }
                    }
                    else if ((i + 1) % 3 == 0)
                    {
                        resultPhNum.Append("-");
                    }
                }
            }
            var res = resultPhNum.ToString();
            return res.TrimEnd('-');
        }

        private static string FormatPhone_RahulKasbe(string input)
        {
            StringBuilder PhoneNumer = new StringBuilder();
            string phoneString = input.Replace("-", String.Empty);
            phoneString = phoneString.Replace(" ", String.Empty);

            char[] phoneArray = phoneString.ToArray();
            for (int J = 0; J < phoneArray.Length; J++)
            {
                PhoneNumer.Append(phoneArray[J]);
                if (PhoneNumer.Length % 3 == 0)
                {
                    PhoneNumer.Append("-");
                }
            }
            return PhoneNumer.ToString();
        }

        private static int HighestSibling_Vrushali(int n)
        {
            var arr = new int[5];
            int i = 0;
            while (n > 0)
            {
                arr[i] = n % 10;
                n = n / 10;
                i++;
            }
            for (i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length;
                j++)
                {
                    int temp = 0;
                    if (arr[j] >= arr[i])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            int max = 0;
            for (i = 0; i < arr.Length; i++)
            {
                max = (max * 10) + arr[i];
            }
            return max;
        }

        /// <summary>
        /// Jaldhi Ozha
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        private static int HighestSibling(int N)
        {
            string OriginalNumber = N.ToString();
            var value = OriginalNumber.ToArray();
            List<int> FamilyN = new List<int>();
            int j = 1;
            for (int i = 0; i <= value.Length - 1; i++)
            {
                if (j == value.Length) break;
                var val = value[j].ToString() + value[i].ToString() + value[value.Length - 1].ToString();
                j++;
                FamilyN.Add(int.Parse(val.ToString()));
            }
            var reverseArray = OriginalNumber.ToString().Reverse().ToArray();
            string reverse = string.Empty;
            for (int i = 0; i <= reverseArray.Length - 1;
            i++)
            {
                reverse += reverseArray[i].ToString();
            }
            FamilyN.Add(int.Parse(reverse));

            return FamilyN.Max<int>();
        }

        private static int MinDistance_NileshKale(int[] A)
        {
            int First = A[0];
            int Second = 0;
            for (int i = 0; i < A.Length; i++)
            {

                if (A[i] < First)
                {
                    First = A[i];
                }
                else if (A[i] <= First)
                {
                    Second = A[i];
                }
            }

            return First - Second;
        }

        private static int GetHighestPower(int ip)
        {
            int res = 0;
            for (int i = 0; Math.Pow(2, i) <= ip; i++)
            {
                var powRes = Math.Pow(2, i);
                if (ip % powRes == 0)
                    res = i;
            }
            return res;
        }

        /// <summary>
        /// Wasim ;)
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private static string GetLargestFamilyForInt(int num)
        {
            var result = string.Empty;
            var list = num.ToString().ToArray().ToList();
            list.Sort();
            list.Reverse();
            result = string.Concat(list);
            return result;
        }

        /// <summary>
        /// Sagar Vernekar
        /// </summary>
        public static void GetHighestDigit()
        {
            Console.WriteLine("Enter number");
            string num = Console.ReadLine();
            //213

            char[] originalNumber = num.ToCharArray(); //e.g. 213

            //parsed originalNumber into int[]
            int[] arr = new int[num.Length];
            if (originalNumber.Length ==
            arr.Length)
            {
                for (int j = 0; j <
                originalNumber.Length; j++)
                {
                    arr[j] = originalNumber[j];
                }
            }
            //sorting code
            int temp;
            for (int x = 0; x < arr.Length - 1;
            x++)
            {
                for (int y = 0; y < arr.Length - 1;
                y++)
                {
                    if (arr[y] < arr[y + 1])
                    {
                        temp = arr[y + 1];
                        arr[y + 1] = arr[y];
                        arr[y] = temp;
                    }
                }
            }

            string LargestNumber = string.Empty;
            for (int a = 0; a < arr.Length; a++)
            {
                LargestNumber = LargestNumber +
                (char)(arr[a]);
            }


            Console.WriteLine("Largest number is " + LargestNumber);
        }


        /// <summary>
        /// Vikram Nandanvar
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public static int solution(int N)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            List<char> output = new List<char>();
            Console.WriteLine("Enter the Number in range 0 to 10000 to find the max of it.");
            string input = Console.ReadLine();
            var array = input.ToArray();

            while (array.Any())
            {
                var maxItem = array.Max();
                output.Add(maxItem);
                array = array.Where(x => x != maxItem).ToArray();
            }

            StringBuilder abc = new
            StringBuilder();

            foreach (var item in output)
            {
                abc.Append(item);
            }


            Console.WriteLine(Convert.ToInt32(abc.ToString()));
            Console.ReadLine();

            return Convert.ToInt32(abc.ToString());
        }

        /// <summary>
        /// Ashish Keswani
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int solution(int[] A)
        {

            int differnce = 0;
            int smallIndex = 0;


            int smallestElem = A[0];
            int secondsmallest = A[1];

            for (int i = 0; i < A.Count(); i++)
            {
                if (A[i] < smallestElem)
                {
                    smallestElem = A[i];
                    smallIndex = i;
                }
            }

            for (int i = 0; i < A.Count(); i++)
            {
                if (i != smallIndex)
                {
                    if (A[i] < secondsmallest)
                    {
                        if (A[i] >= smallestElem)
                        {
                            secondsmallest =
                            A[i];
                        }
                    }
                }
            }

            differnce = secondsmallest - smallestElem;

            return differnce;


        }

        public static int getLargestSibling(int x)
        {
            int largestSiblingLimit = 100000;
            char _tempChar;
            char[] _arrayChar =
            x.ToString().Where(Char.IsDigit).ToArray();
            string[] _temp = new
            string[_arrayChar.Length];
            char[] _arrangedNumber = new
            char[_arrayChar.Length];
            string _arrangedStringNumbers =
            string.Empty;

            for (int i = 0; i <=
            _arrayChar.Length - 1; i++)
            {
                for (int j = 0; j <=
                _arrayChar.Length - 1; j++)
                {
                    int next = j ==
                    _arrayChar.Length - 1 ? _arrayChar.Length - 1 : j +
                    1;
                    if (_arrayChar[j] <
                    _arrayChar[next])
                    {
                        _tempChar =
                        _arrayChar[next];
                        _arrayChar[next] =
                        _arrayChar[j];
                        _arrayChar[j] =
                        _tempChar;
                    }
                }
            }
            for (int f = 0; f <
            _arrayChar.Length; f++)
            {
                _temp[f] = _arrayChar[f].ToString();
            }

            _arrangedStringNumbers =
            string.Join("", _temp);

            if (int.Parse(_arrangedStringNumbers)
            > largestSiblingLimit)
                return -1;

            return
            int.Parse(_arrangedStringNumbers);
        }

        public static void AtulGaikwad(UInt32 N)
        {
            List<UInt32> numbers = new
            List<UInt32>();
            UInt32 reminder = 0;
            UInt32 input = N;
            while (input > 0)
            {

                reminder = input % 10;
                numbers.Add(reminder);
                input = input / 10;
            }
            numbers.Sort();
            numbers.Reverse();

            StringBuilder largestnumber = new
            StringBuilder();

            foreach (int number in numbers)
            {

                largestnumber.Append(number.ToString());
            }

            Console.WriteLine("\n Largest number in the family of {0} is {1}", N.ToString(), largestnumber.ToString());
        }
    }
}

/// <summary>
/// Ankush Tarange
/// </summary>
public class Solution
{
    public int solution(int N)
    {
        int lSibling = 0;

        int max = 0;
        int currentDigit = 0, nextdigt = 0;
        int number = N;

        while (N > 0)
        {
            while (number > 0)
            {
                int digit = number % 10;
                max = Math.Max(max, digit);
                N /= 10;
            }

            currentDigit = max;

            lSibling = (lSibling + currentDigit) * 10;
        }

        lSibling = lSibling / 10;

        return lSibling;

    }
}
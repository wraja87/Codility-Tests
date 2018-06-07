using System;
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
            #region CardsWar
            var CardA = "K2Q25";
            var CardB = "23A84";
            //Console.WriteLine(AakanshaGupta_CalculateScore(CardA, CardB));            
            #endregion
            #region CreativeAccounting
            var inputNumber = 123456;
            //Console.WriteLine(NikhilAsarkar(inputNumber.ToString())); 
            //Console.WriteLine(GajananGogurwar(inputNumber.ToString()));
            //Console.WriteLine(BalasahebKadam(inputNumber.ToString()));
            //Console.WriteLine(ParvezAhmed(inputNumber));
            Console.WriteLine(CreativeAccounting_BhushanFutane(inputNumber));
            #endregion
            //int[] A = new int[] {8, 24, 3, 20, 1, 17 };
            //int[] A = new int[] { 7, 21, 5, 42, 3, 8 };
            //Console.WriteLine(GetHigeshtDeviation_Jayesh(A));
            #region TowDigitHours
            var startTime = "15:15:00";
            var endTime = "15:15:12";
            //var startTime = "22:22:21";
            //var endTime = "22:22:23";
            //Console.WriteLine(WasimPoonawala_TowDigitHours(startTime, endTime));
            #endregion
            #region HoursTwoDigits
            var ip1 = new DateTime(2018, 1, 1, 13, 13, 12); //"13:13:12";//"12:34:50";
            var ip2 = new DateTime(2018, 1, 1, 13, 13, 15);//"13:13:15";// "13:01:01";
            //Console.WriteLine(DineshKanojiya(ip1.ToString(), ip2.ToString()));
            #endregion
            #region LongestSentence
            var F2_IP1 = "We test coders. Give us a try?";
            var F2_IP2 = "Forget CVs..Save time . x x ? x";
            //Console.WriteLine(RahulSutar_Method(F2_IP1));
            //Console.WriteLine(RahulSutar_Method(F2_IP2));
            //Console.WriteLine(VatsalShah_Method(F2_IP2));
            //Console.WriteLine(AnupKshirsagar_Method(F2_IP2));
            #endregion
            Console.ReadLine();
        }
        #region Cards War

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
        #region JohnDoe
        public static int JohnDoe_CardWar(string A, string B)
        {
            int N = 0;
            var sanew = A.ToUpper().ToCharArray().ToArray();
            var sbnew = B.ToUpper().ToCharArray().ToArray();
            for (int i = 0; i < A.Length; i++)
            {
                N = N + JohnDoe_winner(sanew[i], sbnew[i]);
            }
            return N;
        }

        public static int JohnDoe_winner(char a, char b)
        {
            String nset = "23456789TJQKA";
            var posA = nset.IndexOf(a);
            var posB = nset.IndexOf(b);

            if (posA <= posB)
                return 0;
            return 1;

        }
        #endregion
        private static int CardsWar_SanketKurade(string CardA, string CardB)
        {
            Array alc = new string[5];
            Array bob = new string[5];
            alc = CardA.Split(',');
            bob = CardB.Split(',');
            List<int> count = new List<int>();
            //foreach (var item1 in alc)
            //{
            //    int a;
            //    int b;
            //    if (item1 == "j")
            //    {
            //        a = 11;
            //    }
            //    if (item1 == "K")
            //    {
            //        a = 11;
            //    }
            //    if (item1 == "Q")
            //    {
            //        a = 11;
            //    }
            //    if (item1 == "A")
            //    {
            //        a = 15;
            //    }
            //    foreach (var item2 in bob)
            //    {
            //        if (item1 ==                     "j")
            //        {
            //            b = 11;
            //        }
            //        if (item1 ==                    "K")
            //        {
            //            b = 11;
            //        }
            //        if (item1 ==                    "Q")
            //        {
            //            b = 11;
            //        }
            //        if (item1 ==                   "A")
            //        {
            //            b = 15;
            //        }
            //        if (a > b)
            //        {

            //            count.Add(1);
            //        }
            //    }
            //}
            return count.Count;
        }
        #region NiteshPatil

        //        public static int NiteshPatil(string A, string B)
        //        { 
        //            Encoding ascii = Encoding.ASCII;
        //        int a = A.Length;
        //int b = B.Length;
        //int count = 0; 
        //for (int i = 0; i < a; i++)
        // {
        // if(A[i]!=B[i])
        // {
        // switch(A[i])
        // {
        // case 'A':
        // if(B[i] != 'A')
        //    count = count + 1;
        //break;
        // case 'K':
        // if(B[i] != 'K' || B[i] != 'A')
        //count = count + 1;
        //break;
        // case 'Q':
        //     if(B[i] != 'Q' || B[i] != 'K' || B[i] !='A')
        //count = count + 1;
        //break;
        //case 'J':
        //if(B[i] != 'J' || B[i] != 'Q' || B[i] !='K' || B[i] != 'A')
        //count = count + 1;
        //break;
        // case 'T':
        // if(B[i] != 'T' || B[i] != 'Q' || B[i] !='K' || B[i] != 'A')
        //count = count + 1;
        //break;
        // case '9':
        //if(aswe.GetCharCount(B[i])<9)
        //{
        //count ++;
        //}
        //break;
        // case '8':
        //if(ascii.GetCharCount(B[i])]<8)
        //{
        //count ++;
        //}
        //break;
        // case '7':
        //if(aswe.GetCharCount(B[i])>7)
        //{
        //    count ++;
        //}
        //break;
        // case '6':
        //if(aswe.GetCharCount(B[i])>6)
        //{
        //count ++;
        //}
        //break;
        // case '5':
        //if(aswe.GetCharCount(B[i])>5)
        //{
        //count ++;
        //}
        //break;
        // case '4':
        //if(aswe.GetCharCount(B[i])>4)
        //{
        //count ++;
        //}
        //break;
        // case '3':
        //if(aswe.GetCharCount(B[i])>3)
        //{
        //count ++;
        //}
        //break;
        //case '2':
        //if(aswe.GetCharCount(B[i])>2)
        //{
        //count ++;
        //}
        //break;
        //};
        //}
        //}

        //return count;
        // }
        // }
        //        }

        #endregion
        #region AakanshaGupta
        public static int AakanshaGupta_CalculateScore(string Alec, string Bob)
        {

            int[] Alexdeck = new int[Alec.Length];
            int[] Bobdeck = new int[Bob.Length];
            int Alexscore = 0;
            int BobScore = 0;

            //Replace J,K,Q,A,T string with numbers
            Alexdeck = AakanshaGupta_ReplaceString(Alexdeck, Alec);
            Bobdeck = AakanshaGupta_ReplaceString(Bobdeck, Bob);

            if (Alexdeck.Length == Bobdeck.Length)
            {
                //Players has equal cards
                int i = 0;

                foreach (int a in Alexdeck)
                {
                    if (Alexdeck[i] > Bobdeck[i])
                    {
                        Alexscore++;
                    }
                    else
                    {
                        BobScore++;
                    }
                }
                if (Alexscore > BobScore)
                {
                    Console.WriteLine("Alex Wins game with" + Alexscore + " turns");
                    Console.ReadLine();
                    return Alexscore;
                }
                else
                {
                    Console.WriteLine("Bob Wins game with " + BobScore + " turns");
                    Console.ReadLine();
                    return Alexscore;
                }
            }
            else
            {
                //Player does not have equal cards
                Console.WriteLine("Error: Cards are not equal");
                Console.ReadLine();
                return 0;
            }

        }
        public static int[] AakanshaGupta_ReplaceString(int[] arr, string player)
        {
            int[] deck = new int[arr.Length];

            for (int i = 1; i < deck.Length; i++)
            {
                char[] c = player.ToCharArray();
                if (c[i] == 'A')
                {
                    deck[i] = 14;
                }
                else if (c[i] == 'K')
                {
                    deck[i] = 13;
                }
                else if (c[i] == 'Q')
                {
                    deck[i] = 12;
                }
                else if (c[i] == 'J')
                {
                    deck[i] = 11;
                }
                else if (c[i] == 'T')
                {
                    deck[i] = 10;
                }
                else
                {
                    deck[i] = i;
                }


            }
            return deck;
        }
        #endregion

        private static int CardsWar_ShivrajSatpute(string CardA, string cardB)
        {
            return -1;
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

        public static int GajananGogurwar(string inputNumber)
        {
            int[] number = { 1, 2, 2, 8, 5 };
            StringBuilder arr = new StringBuilder();
            if (number.Length >= 0 && number.Length != 0)
            {
                for (int i = 0; i < number.Length; i++)
                {
                    if (i == 0)
                    {
                        arr.Append(number[i]);
                    }
                    else if (i == number.Length - 1)
                    {
                        arr.Append(number[i]);
                    }
                    else if (i == 1)
                    {
                        arr.Append(number[i]);
                    }
                    else if (i == number.Length - 2)
                    {
                        arr.Append(number[i]);
                    }
                    else
                    {
                        arr.Append(number[i]);
                    }
                }
                Console.Write(arr);
                int q = Convert.ToInt32(arr);
                return q;
            }
            return 0;
        }

        public static int BalasahebKadam(string inputNumber)
        {
            char[] s = inputNumber.ToCharArray();
            char[] shuffledNo = new char[inputNumber.Length];
            int len = inputNumber.ToString().Length - 1;
            int j = 0;
            for (int i = 0; i < len; i++)
            {
                shuffledNo[j] = s[i];
                shuffledNo[j + 1] = s[len - i];
                i = i + 2;
                j = j + 1;
            }
            return Convert.ToInt32(new string(shuffledNo));
        }

        public static int ParvezAhmed(int inputNumber)
        {
            int[] arr = ParvezAhmed_digitArr(inputNumber);
            arr = ParvezAhmed_ShuffleArray(arr);
            string arrstr = "";
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                arrstr += arr[i].ToString();
            }
            return int.Parse(arrstr);
        }

        public static int[] ParvezAhmed_ShuffleArray(int[] array)
        {
            Random r = new Random();
            for (int i = array.Length; i > 0; i--)
            {
                int j = r.Next(i);


                int k = array[j];
                array[j] = array[i - 1];
                array[i - 1] = k;
            }
            return array;

        }

        public static int[] ParvezAhmed_digitArr(int n)
        {
            if (n == 0) return new int[1] { 0 };

            var digits = new List<int>();

            for (; n != 0; n /= 10)
                digits.Add(n % 10);

            var arr = digits.ToArray();
            Array.Reverse(arr);
            return arr;
        }

        public static int CreativeAccounting_BhushanFutane(int A)
        {
            string numberString = A + "";
            char[] numberCharArr = numberString.ToArray();
            int[] numberArr = new int[numberString.Length];

            for (int i = 0; i < numberCharArr.Length; i++)
            {
                numberArr[i] = Convert.ToInt32(numberCharArr[i] + "");
            }
            //Sort in Descending oder
            for (int i = 0; i < numberArr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    int x = numberArr[i];
                    numberArr[i] = numberArr[j];
                    numberArr[j] = x;
                }
            }

            string Lnum = string.Join("", numberArr);//Convert.ToString(numberArr.ToList());
            return (Convert.ToInt32(Lnum));
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
        #region TowDigitHours

        private static int DineshKanojiya(string S, string T)
        {
            int res = 0;
            try
            {
                //DateTime sdf = new DateTime();
                DateTime date1 = DateTime.Parse(S);
                DateTime date2 = DateTime.Parse(T);
                TimeSpan diff = date2.TimeOfDay - date1.TimeOfDay;
                //long diffSeconds = Convert.ToInt32(diff) / 1000 % 60;
                long diffSeconds = diff.Seconds;// / 1000 % 60;
                String[] result = new String[(((int)diffSeconds) + 2) - 1];
                for (int i = 0; i < result.Length; i++)
                {
                    if (i == 0)
                    {
                        result[0] = S;
                    }
                    else
                    {
                        DateTime d1 = DateTime.Parse(result[0]);
                        DateTime d = new DateTime(Convert.ToInt32(d1.TimeOfDay) + ((i) * 1000));
                        result[i] = d.ToShortTimeString();
                    }
                }

                HashSet<int> set = new HashSet<int>();
                for (int i = 0; i < result.Length; i++)
                {
                    set = new HashSet<int>();
                    String str = result[i];
                    String[] strA = str.Split(':');
                    for (int j = 0; j < strA.Length; j++)
                    {
                        String strD = strA[j];
                        char[] c = strD.ToCharArray();
                        char c1 = c[0];
                        char c2 = c[1];
                        if (c1 == c2)
                        {

                            set.Add((int)c1);
                        }
                        else
                        {

                            set.Add(c1);

                            set.Add(c2);
                        }
                    }
                    if (set.Count <= 2)
                    {
                        res++;
                    }
                }
            }
            catch (Exception ex)
            {

                //Console.WriteLine(Ex.ToString());
            }
            return res;
        }

        private static int AvinashSaxena(string S, string T)
        {
            string strHourS = S.Substring(0, 2);
            string strMinS = S.Substring(3, 2);
            string strSecS = S.Substring(6, 2);

            string strHourT = T.Substring(0, 2);
            string strMinT = T.Substring(3, 2);
            string strSecT = T.Substring(6, 2);
            int retVal = 0;
            if (strHourS == strHourT)
            {
                if (strMinS == strMinT)
                {
                    if (strSecS == strSecT)
                    {
                        retVal = 1;
                    }
                    else
                        retVal = 2;
                }
                retVal = 3;
            }
            return retVal;
        }

        private static int WasimPoonawala_TowDigitHours(string S, string T)
        {
            var intPoints = 0;
            var startTime = new TimeSpan(int.Parse(S.Substring(0, 2)), int.Parse(S.Substring(3, 2)), int.Parse(S.Substring(6, 2)));
            var endTime = new TimeSpan(int.Parse(T.Substring(0, 2)), int.Parse(T.Substring(3, 2)), int.Parse(T.Substring(6, 2)));
            for (; startTime <= endTime; startTime = startTime.Add(TimeSpan.FromSeconds(1)))
            {
                var timeString = startTime.ToString("hhmmss");
                var uniqueDigitsCount = WasimPoonawala_TowDigitHours_GetUniqeCharsCount(timeString);//timeString.ToCharArray().GroupBy(x => x).ToList();
                if (uniqueDigitsCount < 3)
                    intPoints++;
            }
            return intPoints;
        }

        private static int WasimPoonawala_TowDigitHours_GetUniqeCharsCount(string inputString)
        {
            var charArray = inputString.ToCharArray();
            var charList = new List<char>();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (!charList.Contains(charArray[i]))
                {
                    charList.Add(charArray[i]);
                }
            }
            return charList.Count;
        }

        #endregion
        #region LongestSentence
        private static int RahulSutar_Method(string sentence)
        {
            char[] delimit = { '.', '?', '!' };
            var sentenseArr = sentence.Split(delimit);
            var maxWords = (from s in sentenseArr
                            where !string.IsNullOrWhiteSpace(s)
                            select s);
            var cnt = maxWords.Count();
            return cnt;
        }

        private static int VatsalShah_Method(string sentence)
        {
            string[] stringDotArray = sentence.Split('.');
            int maximumWordLength = 0;
            foreach (string word in stringDotArray)
            {
                string wordDetail = word.TrimStart(' ').TrimEnd(' ').Replace(" ", " ");
                if (wordDetail.Length > 0)
                {
                    string[] totalWords = wordDetail.Split(' ');
                    if (totalWords.Count() > maximumWordLength)
                    {
                        maximumWordLength = totalWords.Count();
                    }
                    if (word.IndexOf("?") != -1)
                    {
                        string[] stringQuestionMarkArray = word.Split('?');
                        foreach (string questionMark in stringQuestionMarkArray)
                        {
                            wordDetail = questionMark.TrimStart(' ').TrimEnd(' ').Replace(" ", "");
                            if (wordDetail.Length > 0)
                            {
                                totalWords = wordDetail.Split(' ');
                                if (totalWords.Count() > maximumWordLength)
                                {
                                    maximumWordLength = totalWords.Count();
                                }
                                if (wordDetail.IndexOf("!") != -1)
                                {
                                    string[] stringexclamationMarkArray = wordDetail.Split('!');
                                }
                            }
                        }
                    }
                }
            }
            return maximumWordLength;
        }

        private static int AnupKshirsagar_Method(string sentence)
        {
            string[] strArray = sentence.Split(Convert.ToChar("."), Convert.ToChar("!"), Convert.ToChar("?")).ToArray();
            int wordCount = 0;
            foreach (string s in strArray)
            {
                if (!String.IsNullOrEmpty(s))
                {
                    string temp = s.Trim();
                    int count = temp.Split(Convert.ToChar(" ")).Count();
                    if (wordCount < count || wordCount == 0)
                    {
                        wordCount = count;
                    }
                }
            }
            return wordCount;
        }
        private static int LongestSentence_Mine(string sentence)
        {
            char[] delimit = { '.', '?', '!' };
            var sentenseArr = sentence.Split(delimit);
            var maxWords = (from s in sentenseArr
                            where !string.IsNullOrWhiteSpace(s)
                            select s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length).ToList();
            var cnt = maxWords.Max();
            return cnt;
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

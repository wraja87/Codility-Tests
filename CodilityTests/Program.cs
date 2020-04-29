using System;
using System.Collections;
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
            GenStringForLongTest();

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
            var CardA = "23A84Q";
            var CardB = "K2Q25J";
            //Console.WriteLine(CardsWar_KapilNandgave(CardB, CardA));
            //Console.WriteLine(CardsWar_SonaliMali(CardA, CardB));
            //Console.WriteLine(CardsWar_AkshayPanchariya(CardA, CardB));
            //Console.WriteLine(CardsWar_MohitDubey(CardA, CardB));
            #endregion
            #region CreativeAccounting
            var inputNumber = 123456;
            //Console.WriteLine(NikhilAsarkar(inputNumber.ToString())); 
            //Console.WriteLine(GajananGogurwar(inputNumber.ToString()));
            //Console.WriteLine(BalasahebKadam(inputNumber.ToString()));
            //Console.WriteLine(ParvezAhmed(inputNumber));
            //Console.WriteLine(CreativeAccounting_BhushanFutane(inputNumber));
            //Console.WriteLine(CreativeAccounting_AbdulSheikh(inputNumber));
            //Console.WriteLine(CreativeAccounting_MuskaanSethia(inputNumber));
            //Console.WriteLine(CreativeAccounting_BhagyashriPatil(inputNumber));
            //CreativeAccounting_MeghaModi(inputNumber);
            //CreativeAccounting_PoojaMehta(inputNumber);
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
            #region DecReprSeniorCoding
            var DecReprSeniorCoding_Input = 213;
            //Console.WriteLine(DecReprSeniorCoding_BhushanBand(DecReprSeniorCoding_Input));
            //Console.WriteLine(DecReprSeniorCoding_InderSinghRawat(DecReprSeniorCoding_Input));
            #endregion
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Press ENTER to exit.");
            Console.ReadLine();
        }

        private static void GenStringForLongTest()
        {
            for (int i = 0; i < 5; i++)
            {
                long ImportDocDetailsID = 50456;
                var currentTicks = DateTime.Now.Ticks.ToString();
                var tmpInt = currentTicks.Substring(currentTicks.Length - 9);//last 9 characters in ticks
                var uniqueSureTaxCertificateId = long.Parse(ImportDocDetailsID.ToString() + tmpInt);
                Console.WriteLine("{0} {1} {2} {3}", currentTicks, ImportDocDetailsID, tmpInt, uniqueSureTaxCertificateId);
            }
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

        private static int CardsWar_JayashriGhadge(string CardA, string cardB)
        {
            return -1;
        }

        private static int CardsWar_MaheshGondugade(string CardA, string CardB)
        {
            int winCount = 0;
            if ((!string.IsNullOrWhiteSpace(CardA) && !string.IsNullOrWhiteSpace(CardB)) && (CardA.Length == CardB.Length))
            {
                string[] arrCards = new string[13] { "2", "3", "4", "5", "6", "7", "8", "9", "T", "J", "Q", "K", "A" };

                for (int i = 0; i < CardA.Length - 1; i++)
                {
                    string aInd = Convert.ToString(CardA.ElementAt(i));
                    string bInd = Convert.ToString(CardB.ElementAt(i));

                    int aIndex = Array.IndexOf(arrCards, aInd);
                    int bIndex = Array.IndexOf(arrCards, bInd);

                    if (aIndex > bIndex)
                    {
                        winCount = winCount + 1;
                    }

                }
            }
            return winCount;

        }

        private static int CardsWar_KapilNandgave(string A, string B)
        {
            int totalSumA = 0; int totalSumB = 0;
            var chars = A.ToCharArray();
            var chars1 = B.ToCharArray();
            int AliceCount = 0, blowcount = 0;
            for (int ctr = 0, ctr1 = 0; ctr < chars.Length && ctr1 < chars1.Length; ctr++, ctr1++)
            {
                totalSumA = CardsWar_MaheshGondugade_Checkkar(chars[ctr]);
                totalSumB = CardsWar_MaheshGondugade_Checkkar(chars1[ctr1]);
                if (totalSumA > totalSumB)
                {
                    AliceCount += 1;
                }
                else
                {
                    blowcount += 1;
                }
            }
            if (AliceCount > blowcount)
            {
                return AliceCount;
            }
            else
            {
                return blowcount;
            }
        }

        private static int CardsWar_SonaliMali(string A, string B)
        {
            string[] cardPrioritySeq = new string[13];
            cardPrioritySeq[0] = "A";
            cardPrioritySeq[1] = "K";
            cardPrioritySeq[2] = "Q";
            cardPrioritySeq[3] = "J";
            cardPrioritySeq[4] = "T";
            cardPrioritySeq[5] = "9";
            cardPrioritySeq[6] = "8";
            cardPrioritySeq[7] = "7";
            cardPrioritySeq[8] = "6";
            cardPrioritySeq[9] = "5";
            cardPrioritySeq[10] = "4";
            cardPrioritySeq[11] = "3";
            cardPrioritySeq[12] = "2";
            int alecWinCount = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == B[i])
                    continue;
                int alecIndex = Array.IndexOf(cardPrioritySeq, Convert.ToString(A[i]));
                int bobIndex = Array.IndexOf(cardPrioritySeq, Convert.ToString(B[i]));
                if (alecIndex < bobIndex)
                    alecWinCount = alecWinCount + 1;
            }
            return alecWinCount;
        }

        private static int CardsWar_MaheshGondugade_Checkkar(char c)
        {
            int val = 0;
            var isNumeric = int.TryParse(c.ToString(), out val);
            if (isNumeric)
                val = (int)char.GetNumericValue(c);
            else if (c == 'A')
                val = 14;
            else if (c == 'K')
                val = 13;
            else if (c == 'Q')
                val = 12;
            else if (c == 'j')
                val = 11;
            return val;
        }

        private static int CardsWar_AkshayPanchariya(string A, string B)
        {
            int count = 0;
            A = A.ToUpper();
            B = B.ToUpper();

            List<char> Alace = new List<char>();
            List<char> Bob = new List<char>();

            foreach (char c in A)
            {
                Alace.Add(c);
            }
            foreach (char c in B)
            {
                Bob.Add(c);
            }

            if ((Alace.Count < 6) || (Bob.Count < 6))
            {
                return -1;
            }

            if (Alace.Count != Bob.Count)
            {
                return 0;
            }
            for (int p = 0; p < Alace.Count; p++)
            {
                if (CardsWar_AkshayPanchariya_GetNumber(Alace[p]) != 'S')
                {
                    Alace[p] = CardsWar_AkshayPanchariya_GetNumber(Alace[p]);
                }

            }
            for (int p = 0; p < Bob.Count; p++)
            {
                if (CardsWar_AkshayPanchariya_GetNumber(Bob[p]) != 'S')
                {
                    Bob[p] = CardsWar_AkshayPanchariya_GetNumber(Bob[p]);
                }

            }


            for (int k = 0; k < Alace.Count; k++)
            {
                if (Alace[k] > Bob[k])
                {
                    count++;
                }

            }



            return count;
        }

        public static char CardsWar_AkshayPanchariya_GetNumber(char i)
        {
            //As it is char can not use Double digit number and cant store number from 2 to 9 hence 
            //Can not assign Asccii value of alphabets as its is not correct order
            //assigning ascii values of special character
            if (i == 'A')
                return '@';
            else if (i == 'K')
                return '?';
            else if (i == 'Q')
                return '>';
            else if (i == 'J')
                return '=';
            else
                return 'S';
        }

        private static int CardsWar_MohitDubey(string A, string B)
        {
            var AlecCards = A.ToArray();
            var BobCards = B.ToArray();
            int winCount = 0;
            for (int i = 0; i < AlecCards.Length; i++)
            {
                if (AlecCards[i].ToString() == "A")
                {
                    winCount = winCount + 1;
                }
                if (AlecCards[i].ToString() == "J" || AlecCards[i].ToString() == "T" || AlecCards[i].ToString() == "Q"
                || AlecCards[i].ToString() == "K")
                {
                    if (BobCards[i].ToString() == "2" || BobCards[i].ToString() == "3" || BobCards[i].ToString() == "4"
                    || BobCards[i].ToString() == "5" || BobCards[i].ToString() == "6" || BobCards[i].ToString() == "7" ||
                    BobCards[i].ToString() == "8" || BobCards[i].ToString() == "9")
                    {
                        winCount = winCount + 1;
                    }
                }
                if (AlecCards[i].ToString() == "K" && (BobCards[i].ToString() == "T" || BobCards[i].ToString() ==
                "J" || BobCards[i].ToString() == "Q"))
                {
                    winCount = winCount + 1;
                }
                if (AlecCards[i].ToString() == "Q" && (BobCards[i].ToString() == "T" || BobCards[i].ToString() ==
                "J"))
                {
                    winCount = winCount + 1;
                }
                if (AlecCards[i].ToString() == "J" && (BobCards[i].ToString() == "T"))
                {
                    winCount = winCount + 1;
                }
                if (AlecCards[i].ToString() == "2" || AlecCards[i].ToString() == "3" || AlecCards[i].ToString() ==
                "4" || AlecCards[i].ToString() == "5" || AlecCards[i].ToString() == "6" || AlecCards[i].ToString() == "7" ||
                AlecCards[i].ToString() == "8" || AlecCards[i].ToString() == "9")
                {
                    if (BobCards[i].ToString() == "2" || BobCards[i].ToString() == "3" || BobCards[i].ToString() ==
                    "4" || BobCards[i].ToString() == "5" || BobCards[i].ToString() == "6" || BobCards[i].ToString() == "7" ||
                    BobCards[i].ToString() == "8" || BobCards[i].ToString() == "9")
                    {
                        if (Convert.ToInt32(AlecCards[i].ToString()) > Convert.ToInt32(BobCards[i].ToString()))
                        {
                            winCount = winCount + 1;
                        }
                    }
                }
            }
            return winCount;
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

        public static int CreativeAccounting_BikramC(int A)
        {
            var arr = A.ToString().Select(d => int.Parse(d.ToString())).ToArray();

            var length = arr.Length;

            var result = new StringBuilder(string.Empty);

            for (var i = 0; i <= ((length / 2) - 1); i++)
            {
                result.Append(arr[i]);
                result.Append(arr[(length - 1) - i]);
            }

            if (length % 2 != 0)
            {
                result.Append(arr[(length / 2)]);
            }

            return int.Parse(result.ToString());
        }

        public static int CreativeAccounting_AbdulSheikh(int A)
        {
            String holder = A.ToString();
            char[] Sourcearray = holder.ToCharArray();
            int[] Intsequence = Sourcearray.Select(c => Convert.ToInt32(c.ToString())).ToArray();
            int[] Finalstore = new int[Intsequence.Length];
            return CreativeAccounting_AbdulSheikh_GetIntArray(Intsequence, Intsequence.Length);
        }

        public static int CreativeAccounting_AbdulSheikh_GetIntArray(int[] arr, int n)
        {
            int[] temp = new int[n];
            int first = 0;
            int last = n - 1;
            //last= 5
            bool flag = true;
            //n = 6
            for (int i = 0; i < n; i++)
            {
                if (flag)
                    temp[i] = arr[first++];
                else
                    temp[i] = arr[last--];

                flag = !flag;
            }

            for (int i = 0; i < n; i++)
                arr[i] = temp[i];

            Console.WriteLine("\nModified Array");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            string a = "";
            int output;
            foreach (int test in arr)
            {
                a += test.ToString();
            }

            output = int.Parse(a);
            return output;
        }

        public static int CreativeAccounting_PranjalWalzade(string A)
        {
            int out12; string out13 = null;
            int len = A.Length;

            for (int i = 0; i < len; i++)
            {
                if (out13.Length != len)
                {
                    out12 = i + 1;
                    out13 += out12.ToString();
                    char cLastCharacter = A[A.Length - (i + 1)];
                    out13 += cLastCharacter.ToString();
                }
            }
            int out14 = (int.Parse(out13));
            return out14;
        }

        public static int CreativeAccounting_MuskaanSethia(int numberToShuffle)
        {
            try
            {
                var number = numberToShuffle.ToString();
                int front = 0;
                int back = number.Length - 1;
                string shuffledString = String.Empty;

                while (front <= back)
                {

                    shuffledString += number[front];
                    front++;
                    if (!(front - 1 == back))
                    {
                        shuffledString += number[back];
                        back--;
                    }
                }
                return Convert.ToInt32(shuffledString);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string CreativeAccounting_BhagyashriPatil(int A)
        {
            var inputnum = A;
            int firstindex = 0;
            int lastindex = inputnum.ToString().Length;
            var outputnum = "";
            for (int i = 1; i <= (inputnum.ToString().Length / 2) + 1; i++)
            {
                outputnum = outputnum + inputnum.ToString().Substring(firstindex, 1) +
                inputnum.ToString().Substring((lastindex - 1), 1);
                firstindex += 1;
                lastindex -= 1;
            }
            // Console.WriteLine(outputnum);
            // Console.ReadLine();
            return outputnum;
        }

        public static void CreativeAccounting_MeghaModi(int No)
        {
            int[] str = { No };
            int NofLength = Convert.ToString(No).Length;
            string Value = Convert.ToString(No);
            string NewValue = string.Empty;
            for (int i = 1; i < NofLength; i++)
            {
                for (int j = NofLength - 1; j > 1; j--)
                {
                    NewValue = (Convert.ToString(Value[j]));
                    Console.WriteLine(Value[j]);
                }
                string s1 = (Convert.ToString(Value[i]));
                Console.WriteLine(Value[i]);
                // Console.WriteLine(NewValue.ToString());
            }
        }

        public static int CreativeAccounting_PoojaMehta(int A)
        {
            char[] str = Array.ConvertAll(A.ToString().ToArray(), x => (char)x);
            int[] numbers = Array.ConvertAll(str, c => (int)char.GetNumericValue(c));

            int length = numbers.Length;

            if (length >= 2)
            {
                int n = length - 1;
                int i = 0;
                int current = 0;
                int[] shuffled = new int[length];

                do
                {
                    shuffled[current++] = numbers[i];
                    shuffled[current++] = numbers[n - i];
                    i++;
                } while (i < length / 2);

                if (length % 2 != 0)
                    shuffled[n] = numbers[current - 1];

                var res = shuffled.Select((t, j) => t * Convert.ToInt32(Math.Pow(10, shuffled.Length - j - 1))).Sum();
                return res;
            }
            return numbers[0];
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


        private static int TowDigitHours_Jyotsna(string S, string T)
        {
            TimeSpan duration = DateTime.Parse(T).Subtract(DateTime.Parse(S));
            int i = duration.Seconds;
            return i;
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

        #region DecReprSeniorCoding

        public static int DecReprSeniorCoding_AkshayPanchariya(int N)
        {
            int x = N;
            List<int> al = new List<int>();
            string s = x.ToString();
            int len = s.Length;
            string digit1 = s[0].ToString();
            string digit2 = s[1].ToString();
            string digit3 = s[2].ToString();
            string Combination1 = digit1 + digit2 + digit3;
            string Combination2 = digit1 + digit3 + digit2;
            string Combination3 = digit3 + digit2 + digit1;
            string Combination4 = digit3 + digit1 + digit2;
            string Combination5 = digit2 + digit1 + digit3;
            string Combination6 = digit2 + digit3 + digit2;
            int Num1 = Int32.Parse(Combination1);
            int Num2 = Int32.Parse(Combination2);
            int Num3 = Int32.Parse(Combination3);
            int Num4 = Int32.Parse(Combination4);
            int Num5 = Int32.Parse(Combination5);
            int Num6 = Int32.Parse(Combination6);
            al.Add(Num1);
            al.Add(Num2);
            al.Add(Num3);
            al.Add(Num4);
            al.Add(Num5);
            al.Add(Num6);
            int MaxComb = al.Max();
            return MaxComb;
        }

        public static int DecReprSeniorCoding_PiyushSrivastava(int inp)
        {
            ArrayList arr = new ArrayList();
            while (inp > 0)
            {
                if (inp % 10 != 0)
                {
                    arr.Add(inp % 10);
                }
                inp = inp / 10;
            }
            List<int> num = new List<int>();
            for (int j = 0; j < arr.Count; j++)
            {
                num.Add(int.Parse(arr[j].ToString()));
            }

            var res = DecReprSeniorCoding_PiyushSrivastava_GetCombination(num);
            return res;
        }

        public static int DecReprSeniorCoding_PiyushSrivastava_GetCombination(List<int> list)
        {
            int final = 0;
            double count = Math.Pow(2, list.Count);
            List<int> result = new List<int>();
            for (int i = 1; i <= count - 1; i++)
            {
                string str = Convert.ToString(i, 2).PadLeft(list.Count, '0');
                string temp = "";
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[j] == '1')
                    {
                        Console.Write(list[j]);
                        temp += list[j].ToString();
                    }
                    //result.Add(temp);
                }
                result.Add(Convert.ToInt32(temp));
                Console.WriteLine();
            }
            final = result.Max();
            return final;
        }

        public static string DecReprSeniorCoding_BhushanBand(int N)
        {
            int n2 = N;
            var digits = new List<int>();
            int temp = 0;
            var result = "";
            for (; n2 != 0; n2 /= 10)
            {
                digits.Add(n2 % 10);
            }
            var arr2 = digits;
            for (int num = 0; num < arr2.Count; num++)
            {
                for (int sort = 0; sort < arr2.Count - 1; sort++)
                {
                    if (arr2[sort] < arr2[sort + 1])
                    {
                        temp = arr2[sort + 1];
                        arr2[sort + 1] = arr2[sort];
                        arr2[sort] = temp;
                    }
                }
            }
            for (int i = 0; i < arr2.Count; i++)
            {
                result = result + arr2[i] + "";
            }
            return result;
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

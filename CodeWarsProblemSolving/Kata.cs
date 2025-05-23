﻿namespace CodeWarsProblemSolving
{
    public static class Kata
    {

        public static int DescendingOrderTest(int num)
        {

            return Convert.ToInt32(string.Join("", num.ToString().ToCharArray().OrderByDescending(x => x).ToArray()));
        }

        public static string Longest(string s1, string s2)
        {
            var newword = s1 + s2;
            var letters = newword.ToCharArray().Distinct().ToArray();
            Array.Sort(letters);
            return string.Join("", letters);
        }

        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            return listOfItems.Where(x => x is int).Cast<int>().ToList();
        }

        public static int FindShort(string s)
        {
            var words = s.Split(' ');
            int minLengthWord = words[0].Length;

            for (int i = 1; i < words.Length; i++)
            {
                if (words[i].Length < minLengthWord)
                {
                    minLengthWord = words[i].Length;
                }
            }

            return minLengthWord;
        }
        public static int CockroachSpeed(double x)
        {
            //#Happy Coding! ^_^
            return Convert.ToInt32(Math.Floor((x * 1000) * 100 / 3600));
        }

        public static int HexToDec(string hexString)
        {
            if (hexString.StartsWith('-'))
            {
                hexString = hexString.Substring(1);
                return -Convert.ToInt32(hexString, 16);
            }

            return Convert.ToInt32(hexString, 16);
        }
        public static int RentalCarCost(int d)
        {
            // your code
            return d >= 7 ? d * 40 - 50 : d >= 3 ? d * 40 - 20 : d * 40;
        }

        public static int Gimme(double[] inputArray)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] < inputArray.Max() && inputArray[i] > inputArray.Min())
                    return i;
            }
            return 0;
        }

        public static int NoBoringZeros(int n)
        {
            return int.Parse(n.ToString().TrimEnd('0'));
        }

        public static int DescendingOrder(int num)
        {
            // Bust a move right here

            var numbers = num.ToString().Split("");

            return 0;
        }

        public static string HighAndLow(string numbers)
        {
            // Code here or
            var numbersList = numbers.Split(' ').Select(int.Parse).ToList();

            numbersList.Sort();

            return string.Join(' ', numbersList.Last(), numbersList.First());

        }

        public static string ReverseWords(string str)
        {
            // Split the string into words
            string[] words = str.Split(' ');

            var reversedWord = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                reversedWord.Add(revers(words[i]));
            }

            return string.Join(" ", reversedWord);

        }

        public static string revers(string word)
        {
            var reversedWord = string.Empty;

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedWord += word[i];
            }
            return reversedWord;
        }


        public static double Arithmetic(double a, double b, string op)
        {
            switch (op)
            {
                case "add":
                    return a + b;
                case "subtract":
                    return a - b;
                case "multiply":
                    return a * b;
                case "divide":
                    return a / b;
                default:
                    return 0;
            }
        }
        public static List<int> ReverseList(List<int> list)
        {


            return list.AsEnumerable().Reverse().ToList();
        }
        public static int TwiceAsOld(int dadYears, int sonYears)
        {
            // Add you code here.
            return Math.Abs((sonYears * 2) - dadYears);
        }
        public static List<int>[] PowersOfTwo(int n)
        {
            var list = new List<int>();
            for (int i = 0; i <= n; i++)
            {
                list.Add(2 << i);
            }
            return new List<int>[] { list };

        }
        public static bool CheckForFactor(int num, int factor)
        {
            // code here

            return num % factor == 0 ? true : false;
        }
        public static string StringsSum(string s1, string s2)
        {
            // Write your solution here.
            int sum = 0;
            if (int.TryParse(s1, out int reslut))
            {
                sum += reslut;
            }

            if (int.TryParse(s2, out int result))
            {
                sum += result;
            }



            return sum.ToString();

        }

        public static string TwoSort(string[] s)
        {
            Array.Sort(s, StringComparer.Ordinal);


            string text = string.Empty;

            for (int i = 0; i < s[0].Length; i++)
            {
                text += s[0][i];

                if (i != s[0].Length - 1)
                {
                    text += "***";
                }
            }
            return text.Trim();

        }

        public static int Litres(double time)
        {

            return Convert.ToInt32(Math.Floor(time * 0.5));
        }
        public static int CountSheeps(bool[] sheeps)
        {
            //TODO

            if (sheeps == null || sheeps.Length == 0)
                return 0;


            int count = 0;
            for (int i = 0; i < sheeps.Length; i++)
            {
                if (sheeps[i])
                {
                    count++;
                }
            }
            return count;
        }
        public static bool Check(object[] a, object x)
        {
            return a.Contains(x);

        }
        public static bool Hero(int bullets, int dragons)
        {
            //Do Some Magic...
            return dragons * 2 >= bullets ? true : false;
        }

        public static int SumMix(object[] x)
        {
            int sum = 0;
            for (int i = 0; i < x.Length; i++)
            {

                sum += Convert.ToInt32(x[i]);
            }
            return sum;
        }

        public static int SquareSum(int[] numbers)
        {
            return Convert.ToInt32(numbers.Select(x => Math.Pow(x, 2)).Sum());
        }

        public static string Position(char alphabet)
        {
            if (!char.IsLower(alphabet))
            {
                return "";
            }
            Dictionary<char, int> alphabetDict = new Dictionary<char, int>();
            int i = 1;
            for (char c = 'a'; c <= 'z'; c++)
            {

                alphabetDict[c] = i;
                i++;
            }

            return $"Position of alphabet: {alphabetDict[alphabet]}";
        }

        public static int[] CountPositivesSumNegatives(int[] input)
        {

            if (input == null || input.Length == 0)
                return new int[] { };

            int countPostiveNumbers = 0;

            int sumNegativeNumbers = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > 0)
                {
                    countPostiveNumbers++;
                }
                else
                {
                    sumNegativeNumbers += input[i];
                }

            }

            return new int[] { countPostiveNumbers, sumNegativeNumbers };
        }
        public static float Combat(float health, float damage)
        {
            return health < damage ? 0 : health - damage;
        }

        public static int SaleHotDogs(int n)
        {
            return n >= 10 ? n * 90 : n >= 5 && n < 10 ? n * 95 : n * 100;
        }

        public static string Likes(string[] name)
        {
            if (name.Length == 0)
                return "no one likes this";

            if (name.Length == 1)
                return $"{name[0]} likes this";

            if (name.Length == 2)
                return $"{name[0]} and {name[1]} like this";

            if (name.Length == 3)
                return $"{name[0]}, {name[1]} and {name[2]} like this";

            return $"{name[0]}, {name[1]} and {name.Length - 2} others like this";

        }
        public static string Reverse(string text)
        {
            var words = text.Trim().Split(' ');
            var result = string.Empty;

            for (int i = words.Length - 1; i >= 0; i--)
            {
                result += words[i] + " ";
            }


            return result.Trim();
        }
        public static string Derive(double coefficient, double exponent)
        {
            return $"{coefficient * exponent}x^{exponent - 1}";
        }

        public static int SumDigits(int number)
        {

            var numberString = number.ToString().Where(char.IsDigit).Select(c => int.Parse(c.ToString())).ToArray();
            int sum = 0;

            for (int i = 0; i < numberString.Length; i++)
            {
                sum += Math.Abs(numberString[i]);
            }

            return sum;
        }

        public static int[] DivisibleBy(int[] numbers, int divisor)
        {

            var list = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % divisor == 0)
                {
                    list.Add(numbers[i]);
                }
            }
            return list.ToArray();
        }

        public static int[] distinct(int[] a)
        {
            var list = new List<int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (!list.Contains(a[i]))
                {
                    list.Add(a[i]);
                }
            }
            return list.ToArray();
        }

        public static int Move(int position, int roll)
        {
            int move = roll * 2;
            int newPosition = position + move;
            return newPosition;
        }

        public static string Solve(string s)
        {
            //Do Some Magic
            int lowercaseCount = 0;
            int uppercaseCount = 0;


            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLower(s[i]))
                {
                    lowercaseCount++;
                }
                else if (char.IsUpper(s[i]))
                {
                    uppercaseCount++;
                }
            }

            if (lowercaseCount > uppercaseCount)
            {
                return s.ToLower();
            }

            return uppercaseCount > lowercaseCount ? s.ToUpper() : s.ToLower();


        }
        public static string ToJadenCase(this string phrase)
        {
            string[] words = phrase.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {

                words[i] = words[i].Substring(0, 1).ToUpper() + words[i].Substring(1);

            }
            return String.Join(' ', words);
        }

        public static int OtherAngle(int a, int b)
        {
            return 180 - (a + b);
        }

        public static int[] MergeArrays(int[] arr1, int[] arr2)
        {
            var leftArrayPTR = 0;
            var rightArrayPTR = 0;
            var newList = new List<int>();

            //sort array before merging
            Array.Sort(arr1);
            Array.Sort(arr2);


            while (leftArrayPTR < arr1.Length && rightArrayPTR < arr2.Length)
            {
                if (arr1[leftArrayPTR] < arr2[rightArrayPTR])
                {
                    if (!newList.Contains(arr1[leftArrayPTR]))
                    {
                        newList.Add(arr1[leftArrayPTR]);
                    }

                    leftArrayPTR++;
                }
                else if (arr2[rightArrayPTR] < arr1[leftArrayPTR])
                {
                    if (!newList.Contains(arr2[rightArrayPTR]))
                    {
                        newList.Add(arr2[rightArrayPTR]);
                    }
                    rightArrayPTR++;
                }
                else // if the values are equal

                {
                    if (!newList.Contains(arr1[leftArrayPTR]))
                    {
                        newList.Add(arr1[leftArrayPTR]);
                    }
                    leftArrayPTR++;
                    rightArrayPTR++;
                }

            }

            while (leftArrayPTR < arr1.Length)
            {
                if (!newList.Contains(arr1[leftArrayPTR]))
                {
                    newList.Add(arr1[leftArrayPTR]);
                }
                leftArrayPTR++;
            }

            while (rightArrayPTR < arr2.Length)
            {
                if (!newList.Contains(arr2[rightArrayPTR]))
                {
                    newList.Add(arr2[rightArrayPTR]);
                }
                rightArrayPTR++;
            }


            Array.Sort(newList.ToArray());
            return newList.ToArray();
        }
        public static long[] Digitize(long n)
        {
            if (n <= 0)
            {
                return new long[] { 0 };
            }
            var list = n.ToString().ToCharArray();
            var result = list.Select(x => Convert.ToInt64(x.ToString())).ToArray();
            Array.Reverse(result);
            return result;
        }
        public static string Problem(String a)
        {
            //magic code 
            if (double.TryParse(a, out double result))
            {
                return (result * 50 + 6).ToString();
            }
            return "Error";
        }
        public static bool SpeakEnglish(string sentence)
        {


            return sentence.ToLower().Contains("english");
        }
        public static string Replace(string s)
        {
            //return Regex.Replace(s, @"[aeiou]", "!", RegexOptions.IgnoreCase);

            for (int i = 0; i < s.Length; i++)
            {
                if (isVowel(Convert.ToChar(s[i].ToString().ToLower())))
                {
                    s = s.Replace(s[i], '!');
                }
            }
            return s;
        }

        public static bool isVowel(char c)
        {
            char[] vowel = new char[] { 'a', 'e', 'i', 'o', 'u' };

            for (int i = 0; i < vowel.Length; i++)
            {
                if (vowel[i] == c)
                    return true;
            }

            return false;
        }
        public static bool Xor(bool a, bool b)
        {
            return a != b;
            //return a && b || !a & !b ? false : true;
        }

        public static string Order(string words)
        {
            if (words is null || words == "")
                return "";


            //"is2 Thi1s T4est 3a"-- > "Thi1s is2 3a T4est"
            //"4of Fo1r pe6ople g3ood th5e the2"-- > "Fo1r the2 g3ood 4of th5e pe6ople"
            //""-- > ""
            var list = words.Split(' ');
            var word = string.Empty;

            for (int i = 0; i < list.Length; i++)
            {

                var temp = giveMeWord(list, i + 1);
                if (temp != "not found")
                {
                    word += temp + " ";
                }
            }

            return word.Trim();
        }

        public static string giveMeWord(string[] words, int position)
        {
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(position.ToString()))
                    return words[i];
            }
            return "not found";
        }

        public static string BreakCamelCase(string str)
        {
            // complete the function
            string text = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].ToString() == str[i].ToString().ToUpper())
                {
                    text += " " + str[i];
                }
                else
                {
                    text += str[i];
                }

            }
            return text;
        }
    }
}

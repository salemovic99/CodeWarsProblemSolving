namespace CodeWarsProblemSolving
{
    public static class Kata
    {

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

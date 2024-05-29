using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStringQuestion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reverse();
            Console.WriteLine();
            Palindrome();
            Console.WriteLine();
            ReverseOrderOfWord();
            Console.WriteLine();
            ReverseEachWordAndOrder();
            Console.WriteLine();
            ReverseWordNotOrder();
        }


        public static void Reverse()
        {
            string s = "hello world";

            char[] rev = s.ToCharArray();

            int i, j;
            Console.WriteLine(s);

            for (i = 0, j = s.Length-1; i < j; i++, j--)
            {
                rev[i] = s[j];
                rev[j] = s[i];
            }

            Console.WriteLine("Reverse");
            string revserse = new string(rev);

            Console.WriteLine(revserse);
        }


        public static void Palindrome()
        {
            string s = "aba";

            Console.WriteLine(s);

            bool flag = false;

            for(int i = 0, j = s.Length-1; i < s.Length/2; i++, j--)
            {
                if (s[i] != s[j])
                {
                    flag = false; 
                    break;
                }
                else
                {
                    flag = true;
                }
            }

            if(flag)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }


        public static void ReverseOrderOfWord()
        {
            string s = "hello how are you";

            Console.WriteLine(s);

            string[] str = s.Split(' ');

            string ans = "";

            for(int i = str.Length - 1; i >= 0; i--)
            {
                ans += str[i] + " ";
            }

            Console.WriteLine("Reverse order of word");
            Console.WriteLine(ans);
            //Console.WriteLine(ans.Substring(0, ans.Length-1));
        }


        public static void ReverseEachWordAndOrder()
        {
            string s = "Hello how are you";
            Console.WriteLine(s);

            string str = string.Empty;

            for( int i = s.Length - 1; i >= 0; i--)
            {
                str += s[i];
            }

            Console.WriteLine("Reverse word and order of word");
            Console.WriteLine(str);
        }


        public static void ReverseWordNotOrder()
        {
            string s = "welcome how are you";

            Console.WriteLine(s);

            var spcstr = s.Split(' ');

            string str = "";

            foreach(var w in  spcstr)
            {
                char[] ans = w.ToCharArray();

                for(int i = ans.Length - 1; i >= 0; i--)
                {
                    str += ans[i];
                }

                str += " ";

            }

            Console.WriteLine(str.Trim());
        }

    }
}

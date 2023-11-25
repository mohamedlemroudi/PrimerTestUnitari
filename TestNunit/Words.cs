using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNunit
{
    public class Words
    {
        public static int NumWords(string word)
        {
            return word.Split(" ").Length;
        }

        public static int sumar(int a, int b)
        {
            checked
            {
                return a + b;
            }
        }

        public static int sumar(string a, string b)
        {
            checked
            {
                return Int32.Parse(a) + Int32.Parse(b);
            }
        }
    }
}

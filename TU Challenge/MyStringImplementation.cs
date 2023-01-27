using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyStringImplementation
    {
        public static string BazardString(string input)
        {
            throw new NotImplementedException();
        }

        public static bool IsNullEmptyOrWhiteSpace(string input)
        {
            throw new NotImplementedException();
        }

        public static string MixString(string a, string b)
        {
            throw new NotImplementedException();
        }

        public static string Reverse(string a)
        {
            
            List<char> init = new List<char>(a);
            string result = "";
            string transit = "";
            for (int c = 0; c < a.Length; c++)
            {
                transit += ((char)a[c]);
                for (int d = a.Length; d >= 0;d--)
                    result += ((char)transit[c]);
            }
            return result;
        }

        public static string ToCesarCode(string input, int offset)
        {
            throw new NotImplementedException();
        }

        public static string ToLowerCase(string a)
        {
            List<char> init = new List<char>(a);
            String expected = "";

            for (int c = 0; c < a.Length; c++) 
            {
                if (a[c] >= 'A' && a[c] <= 'Z')
                {
                    expected += (char)(a[c] - 'A' + 'a');
                }
                else if (a[c] == 'É')
                    expected += 'é';
                else if (a[c] == ' ')
                    expected += ' ';
                else
                    expected += a[c];
            }
            return expected;
        }

        public static string UnBazardString(string input)
        {
            throw new NotImplementedException();
        }

        public static string Voyelles(string a)
        {
            string voyelles = ("aeiouyAEIOUY");
            List<char> init = new List<char>(a);
            string expected = "";
            for (int c = 0; c < a.Length; c++)
            {
                for (int j = 0; j < voyelles.Length -1; j++)
                {
                    if (a[c] == voyelles[j])
                    {
                        if (expected.Contains(voyelles[j]))
                        {

                        }
                        else
                        {
                            expected += voyelles[j];
                        }          
                    }
                }

            }
            string result = ToLowerCase(expected);
            return result;
        }
    }
}

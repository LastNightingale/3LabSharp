using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3LabSharp
{
    internal class SecondCryptographer : ICryptographer
    {
        public string Encode(string text)
        {
            StringBuilder sb = new StringBuilder();
            string[] words = text.ToLower().Split(' ');
            foreach (string word in words)
            {
                foreach (char letter in word)
                {
                    if (letter >= 117) sb.Append((char)(97 + (5 - (122 - letter + 1))));
                    else sb.Append((char)(letter + 5));
                }
                sb.Append(' ');
            }
            return sb.ToString();
        }
        public string Decode(string text)
        {
            StringBuilder sb = new StringBuilder();
            string[] words = text.ToLower().Split(' ');
            foreach (string word in words)
            {
                foreach (char letter in word)
                {
                    if (letter <= 101) sb.Append((char)(122 - (5 - (letter - 97 + 1))));
                    else sb.Append((char)(letter - 5));
                }
                sb.Append(' ');
            }
            return sb.ToString();
        }
    }
}

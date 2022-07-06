using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3LabSharp
{
    internal class FirstCryptographer : ICryptographer
    {
        public string Encode(string text)
        {
            StringBuilder sb = new StringBuilder();
            string[] words = text.ToLower().Split(' ');
            foreach (string word in words)
            {
                foreach (char letter in word)
                {
                    if (letter == 122) sb.Append((char)97);
                    else sb.Append((char)(letter + 1));
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
                    if (letter == 97) sb.Append((char)122);
                    else sb.Append((char)(letter - 1));
                }
                sb.Append(' ');
            }
            return sb.ToString();
        }
    }
}

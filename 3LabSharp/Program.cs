using System;

namespace _3LabSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            string text = "I like drinking tea z";
            ICrypt crypt = new FirstCrypt();
            ICryptographer cryptographer = crypt.CreateCryptographer();            
            string firsttext = cryptographer.Encode(text);
            Console.WriteLine(firsttext);
            Console.WriteLine(cryptographer.Decode(firsttext));            
            crypt = new SecondCrypt();
            cryptographer = crypt.CreateCryptographer();
            string secondtext = cryptographer.Encode(text);
            Console.WriteLine(secondtext);
            Console.WriteLine(cryptographer.Decode(secondtext));

        }
    }
}
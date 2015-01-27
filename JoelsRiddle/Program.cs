using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JoelsRiddle
{
    class Program
    {
        static void Main(string[] args)
        {
            string textToParse = "This is a test string. Load in a txt file later.";
            textToParse = textToParse.ToLower();
            int charPerLine = 6;

            string trimmedText = RemoveSpecialCharacters(textToParse);
            using (StreamWriter writer = new StreamWriter("c:\\users\\aaron\\documents\\visual studio 2013\\Projects\\JoelsRiddle\\JoelsRiddle\\ParsedText.txt", true))
            {
                writer.Write("\nSplit by " + charPerLine + ":\n");
                for (int i = 0; i < trimmedText.Length; i += charPerLine)
                {
                    writer.WriteLine(trimmedText.Substring(i, charPerLine));
                }
            }
        }

        public static string RemoveSpecialCharacters(string str)
        {
            return Regex.Replace(str, "[^a-zA-Z]+", "", RegexOptions.Compiled);
        }
    }
}

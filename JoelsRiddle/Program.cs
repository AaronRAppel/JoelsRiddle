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
            string textToParse = "As I have gone alone in thereAnd with my treasures boldI can keep my secret whereAnd hint of riches new and oldBegin it where warm waters haltAnd take it in the canyon downNot far, but too far to walkPut in below the home of BrownFrom there it’s no place for the meekThe end is drawing ever nighThere’ll be no paddle up your creekJust heavy loads and water highIf you’ve been wise and found the blazeLook quickly down, your quest to ceaseBut tarry scant with marvel gazeJust take the chest and go in peaceSo why is it that I must goAnd leave my trove for all to seekThe answers I already knowI’ve done it tired, and now I’m weakSo hear me all and listen goodYour effort will be worth the coldIf you are brave and in the woodI give you title to the gold";
            textToParse = textToParse.ToLower();
            int charPerLine = 12;

            string trimmedText = RemoveSpecialCharacters(textToParse);
            using (StreamWriter writer = new StreamWriter("ParsedText.txt", true))
            {
                writer.Write("\nSplit by " + charPerLine + ":\n");
                for (int i = 0; i < trimmedText.Length; i += charPerLine)
                {
                    writer.WriteLine(trimmedText.Length - i < charPerLine
                        ? trimmedText.Substring(i)
                        : trimmedText.Substring(i, charPerLine));
                }
            }
        }

        public static string RemoveSpecialCharacters(string str)
        {
            return Regex.Replace(str, "[^a-zA-Z]+", "", RegexOptions.Compiled);
        }
    }
}

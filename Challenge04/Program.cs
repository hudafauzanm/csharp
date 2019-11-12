using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Substitution
{
    class Program
    {
        static void Main(string[] args)
        {
            // We have some word collection ...
            var censoredWords = new ArrayList();
            censoredWords.Add("imperdiet");
            censoredWords.Add("dolor");
            censoredWords.Add("duo");

            // and a paragraph.
            var paragraph = "Lorem ipsum dolor sit amet, imperdiet vituperata duo in, nonumy.";

            // Censor the words in paragraph by using * symbol.
            // Output example:
            // Lorem ipsum ***** sit amet, ********* vituperata *** in, nonumy.
            string sPattern = "";
            string sResult = paragraph;

            foreach (string item in censoredWords)
        {
            sPattern = new string('*', item.Length);
            sResult = Regex.Replace(paragraph, item, sPattern);
            paragraph = sResult;
        }

            Console.WriteLine(paragraph);
        }
    }
}

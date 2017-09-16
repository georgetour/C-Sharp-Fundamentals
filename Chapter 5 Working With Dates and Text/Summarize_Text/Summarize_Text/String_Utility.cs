using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summarize_Text
{
    class String_Utility
    {
        //We will limit the words to 20 and add ... at the end without breaking any words
        public static string SummarizeText(string text, int maxLength = 20)
        {


            //Check sentence text
            if (text.Length < maxLength)
            {
                return text;
            }
            else
            {
                //Getting a string array of words
                var words = text.Split(' ');

                var totalCharacters = 0;
                var summaryWords = new List<string>();


                //Get length for each word and add it to total character
                foreach (var word in words)
                {

                    summaryWords.Add(word);

                    //The +1 is because of the space
                    totalCharacters += word.Length + 1;
                    if (totalCharacters > maxLength)
                    {
                        break;
                    }

                }


                var summary = String.Join(" ", summaryWords) + "...";

                return summary;
            }


        }



    }
}

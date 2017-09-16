using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summarize_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "It's a Very very very very Very very very very Very very very very Very very very very long text";

            Console.WriteLine(String_Utility.SummarizeText(sentence, 30));


        }
    }
}

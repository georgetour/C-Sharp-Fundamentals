using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playing_with_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {

            
            //StringBuilder is a mutable string, it's defined in System.Text and it's fast to manipulate strings
            //Not for searching like IndexOf() etc
            var builder = new StringBuilder("Hello World");

            //You can chain all stringbuilder methods
            builder.Append('-', 10)
                    .AppendLine()
                    .Append("header")
                    .AppendLine()
                    .Append('-', 10);

            builder.Replace('-', '*');

            builder.Remove(0, 10);

            builder.Insert(0, new string('-', 10));

            Console.WriteLine(builder);

            Console.WriteLine(builder[0]);

        }
    }
}

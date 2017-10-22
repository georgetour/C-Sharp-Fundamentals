using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_And_FileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //File.Copy two overloads
            //First from to without able to rewrite file if exists
            //Second from to and can overwrite if true
            //Using verbatim string

            var path = @"e:/somefile.jpg";
            File.Copy(@"c:/empty.png", @"e:/empty.png", true);
            File.Delete(path);
            if (File.Exists(path))
            {
                //
            }


            //Read all text from a file
            var content = File.ReadAllText(path);


            //Using FileInfo
            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();

            if (fileInfo.Exists)
            {
                //
            }


        }
    }
}

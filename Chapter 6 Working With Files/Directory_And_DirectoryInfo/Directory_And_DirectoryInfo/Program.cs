using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Directory_And_DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {


            Directory.CreateDirectory(@"c:/newDirectory");

            var files = Directory.GetFiles(@"c:/YUI compressor", "*.*",SearchOption.AllDirectories);

            //GetFiles returns an array string so we can ittirate in it with a foreach loop
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            var directories = Directory.GetDirectories(@"c:/YUI compressor","*.*",SearchOption.AllDirectories);

            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }

            if (Directory.Exists("..."))
            {
                //
            }

            var directoryInfo = new DirectoryInfo("...");

            //Get all files or all directories
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();

        }
    }
}

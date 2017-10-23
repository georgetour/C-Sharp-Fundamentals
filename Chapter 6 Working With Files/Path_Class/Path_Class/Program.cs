using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Path_Class
{
    class Program
    {
        static void Main(string[] args)
        {

            var path = @"c:/newDirectory/empty.png";


            //Return the extension manually
            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            //Using methods from Path class
            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("File name: "+  Path.GetFileName(path));
            Console.WriteLine("File name with no extensions: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("File name with no extensions: " + Path.GetDirectoryName(path));



        }
    }
}

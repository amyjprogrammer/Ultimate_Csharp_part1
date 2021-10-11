using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files_Directories
{
    class File_Dir
    {
        static void Main(string[] args)
        {
            //static methods- faster call
            var path = @"c:\somefile.jpg";
            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
            File.Delete(path);
            
            if (File.Exists(path))
            {
                //code if the file exists
            }
            var content = File.ReadAllText(path);//returns a string of the info at path

            //instance methods
            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //code if the file exists
            }
        }
    }
}

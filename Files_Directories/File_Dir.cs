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
            /*//static methods- faster call
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
            }*/

            //Directories
            /*Directory.CreateDirectory(@"c:\temp\folder1");
            var files = Directory.GetFiles(@"c:\EFAProjects", "*.sln", SearchOption.AllDirectories); //gets an array of strings, with * looking for everything and .sln 
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }*/

            /*var directories = Directory.GetDirectories(@"c:\EFAProjects\CSharp_Fundamentals", "*.*", SearchOption.AllDirectories);
            foreach(var dir in directories)
                Console.WriteLine(dir);//this works on computer

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();*/

            //path
            var path = @"C:\EFAProjects\DevTeam\DevTeam.sln";

            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("File Name: " + Path.GetFileName(path));
            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));
            Console.WriteLine("File Name w/out extension: " + Path.GetFileNameWithoutExtension(path));

        }
    }
}

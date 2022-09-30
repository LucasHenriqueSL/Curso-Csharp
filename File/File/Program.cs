using System;
using System.IO;
namespace FileA
{
    class Program
    {
        static void Main(string[] args)
        {
            string sorcePath = @"c:\temp\file.txt";
            string targetPath = @"c:\temp\file.txt";
            try
            {
                FileInfo fileInfo = new FileInfo(sorcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sorcePath);
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);

            }
        }
    }
}

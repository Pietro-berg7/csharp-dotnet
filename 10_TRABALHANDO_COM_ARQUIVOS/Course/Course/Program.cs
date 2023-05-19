using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\file1.txt";
            // FileStream fs = null;
            StreamReader sr = null;
            
            try
            {
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
                // fs = new FileStream(path, FileMode.Open);
                // sr = new StreamReader(fs);
                // string line = sr.ReadLine();
                // Console.WriteLine(line);
            }
            catch(IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                // if (fs != null) fs.Close(); // fs?.Close();
                if (sr != null) sr.Close(); // sr?.Close();
            }






            //string sourcePath = @"C:\temp\file1.txt";
            //string targetPath = @"C:\temp\file2.txt";

            //try
            //{
            //    FileInfo fileInfo = new FileInfo(sourcePath);
            //    fileInfo.CopyTo(targetPath);
            //    string[] lines = File.ReadAllLines(sourcePath);
            //    foreach (string line in lines)
            //    {
            //        Console.WriteLine(line);
            //    }
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error ocurred");
            //    Console.WriteLine(e.Message);
            //}
        }
    }
}
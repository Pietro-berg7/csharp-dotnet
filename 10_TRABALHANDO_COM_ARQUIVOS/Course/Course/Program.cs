using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\myfolder\file1.txt";

            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());






            //string path = @"c:\temp\myfolder";

            //try
            //{
            //    IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
            //    Console.WriteLine("FOLDERS:");
            //    foreach (string s in folders)
            //    {
            //        Console.WriteLine(s);
            //    }

            //    IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
            //    Console.WriteLine("FILES:");
            //    foreach (string s in files)
            //    {
            //        Console.WriteLine(s);
            //    }

            //    Directory.CreateDirectory(path + @"\newfolder");
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error occurred");
            //    Console.WriteLine(e.Message);
            //}






            //string sourcePath = @"C:\temp\file1.txt";
            //string targetPath = @"C:\temp\file2.txt";

            //try
            //{
            //    string[] lines = File.ReadAllLines(sourcePath);

            //    using (StreamWriter sw = File.AppendText(targetPath))
            //    {
            //        foreach (string line in lines)
            //        {
            //            sw.WriteLine(line.ToUpper());
            //        }
            //    }
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error ocurred");
            //    Console.WriteLine(e.Message);
            //}






            //string path = @"C:\temp\file1.txt";

            //try
            //{
            //    using (StreamReader sr = File.OpenText(path))
            //    {
            //        while (!sr.EndOfStream)
            //        {
            //            string line = sr.ReadLine();
            //            Console.WriteLine(line);
            //        }
            //    }

            //    //using (FileStream fs = new FileStream(path, FileMode.Open))
            //    //{
            //    //    using (StreamReader sr = new StreamReader(fs))
            //    //    {
            //    //        while (!sr.EndOfStream)
            //    //        {
            //    //            string line = sr.ReadLine();
            //    //            Console.WriteLine(line);
            //    //        }
            //    //    }
            //    //}
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error ocurred");
            //    Console.WriteLine(e.Message);
            //}






            //string path = @"C:\temp\file1.txt";
            //// FileStream fs = null;
            //StreamReader sr = null;

            //try
            //{
            //    sr = File.OpenText(path);
            //    while (!sr.EndOfStream)
            //    {
            //        string line = sr.ReadLine();
            //        Console.WriteLine(line);
            //    }
            //    // fs = new FileStream(path, FileMode.Open);
            //    // sr = new StreamReader(fs);
            //    // string line = sr.ReadLine();
            //    // Console.WriteLine(line);
            //}
            //catch(IOException e)
            //{
            //    Console.WriteLine("An error ocurred");
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    // if (fs != null) fs.Close(); // fs?.Close();
            //    if (sr != null) sr.Close(); // sr?.Close();
            //}






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
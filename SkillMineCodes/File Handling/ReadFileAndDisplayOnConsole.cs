using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillMineCodes.FileHandling
{
    public class ReadFileAndDisplayOnConsole
    {
        static void Main(string[] args)
        {
            string path = @"D:\example\n.txt";

            // ----- 1 ------
            using (StreamReader reader = new StreamReader(path))
            {
                string line = null;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            // ----- 2 ------
            //string content = File.ReadAllText(path);
            //Console.WriteLine(content);



            // ----- 3 ------
            //string[] lines = File.ReadAllLines(path);
            //foreach (string line in lines)
            //{
            //    Console.WriteLine(line);
            //}



            // ----- 4 ------
            //using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate))
            //{
            //    byte[] buffer = new byte[1024];
            //    int bytesRead;
            //    while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
            //    {
            //        Console.Write(Encoding.UTF8.GetString(buffer, 0, bytesRead));
            //    }
            //}
        }
    }
}

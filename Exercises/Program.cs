using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> noombars = new List<int>() { 2,435,756,1234,8756};
            noombars.Add(543);
            noombars.Add(7654);
            noombars.Add(2754);
            string fileLocation = @"c:\code\ints.txt";
            FileHelp.WriteToFile(fileLocation, noombars);
            string firstLine = FileHelp.ReadFirstLine(fileLocation);
            Console.WriteLine(firstLine);
        }
    }
}

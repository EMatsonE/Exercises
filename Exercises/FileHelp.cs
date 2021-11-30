using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Exercises
{
    public class FileHelp
    {
        public static void WriteToFile(string fileLocation, List<int> noombars)
        {
            StreamWriter writeOnFile = new StreamWriter(fileLocation, true);

            //should take in ints and convert to string
            StringBuilder builder = new StringBuilder();
            foreach (var number in noombars)
            {
                builder.Append(number.ToString());
                builder.Append("|");
            }
            //writes the thing
            writeOnFile.WriteLine(builder.ToString());
            writeOnFile.Flush();
            writeOnFile.Close();
        }
        //it goes to consol and prints it there so you dont have to go to the file
        public static string ReadFirstLine(string path)
        {
            StreamReader reader = new StreamReader(path);
            string returnValue = reader.ReadLine();
            if (string.IsNullOrEmpty(returnValue))
            {
                return "no value";
            }
            else
            {
                return returnValue;
            }

        }
    }
}

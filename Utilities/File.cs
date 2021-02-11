using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AdventOfCode.Utilities
{
    public static class File
    {
        public static string[] GetLines(string delim, string file)
        {
            string data = string.Empty;
            string[] ar = null;
            try
            {
                var data_file = Path.Combine(AppContext.BaseDirectory, file);
                using (var sr = new StreamReader(data_file))
                {
                    data = sr.ReadToEnd();
                    ar = data.Split(new string[] { delim }, StringSplitOptions.RemoveEmptyEntries);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ex.Message);
            }
            return ar;
        }
    }
}

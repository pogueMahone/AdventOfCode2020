using System;
using System.Text.RegularExpressions;

namespace AdventOfCode
{
    public static class Day4
    {
        public static int GetValidPassportCount()
        {
            int valid_passports = 0;
            string[] delimiterChars = { " ", "\r\n" };
            string no_cid_regex = @"^((?!cid:\d+).)*$";
            var rows = AdventOfCode.Utilities.File.GetLines("\r\n\r\n", "Data\\Day4.txt");
            try
            {
                foreach (var row in rows)
                {
                    var passport = row.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);                   
                    if (passport.Length == 8 || (passport.Length == 7 && Regex.IsMatch(row.Replace("\r\n", string.Empty), no_cid_regex)))
                        valid_passports++;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Batch file error... airport must close for security!");
                Console.WriteLine(ex.Message);
                valid_passports = 0;
            }
            return valid_passports;
        }
    }
}

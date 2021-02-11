using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using AdventOfCode.Models.Day2;
using System.IO;

namespace AdventOfCode
{
    public static class Day2
    {       

        public static int GetValidCount()
        {
            int valid = 0;
            var patterns = AdventOfCode.Utilities.File.GetLines("\r\n", "Data\\Day2.txt");
            foreach (var p in patterns)
            {
                var pp = new PasswordPolicy(p);
                if (pp.ValidByIndex)
                    valid++;
            }
            return valid;
        }       
    }
}

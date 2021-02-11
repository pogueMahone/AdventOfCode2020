using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AdventOfCode
{
    public static class Day3
    {
        public static long FindTrees(int right_increment, int down_increment)
        {
            var rows = AdventOfCode.Utilities.File.GetLines("\r\n", "Data\\Day3.txt");            
            char square;
            char tree = '#';
            int right = 0; //x
            int down = 0; //y
            long tree_count = 0;            
            while (down < rows.Length)
            {                
                var edge = rows[down].Length;
                if (right < edge)
                    square = rows[down][right];
                else 
                {
                    var tmp = (right - edge);
                    right = 0;
                    right += tmp;
                    //down++;
                    square = rows[down][right];
                }
                if (tree.Equals(square))
                    tree_count++;
                right += right_increment;
                down += down_increment;
            }
            return tree_count;
        }
    }
}

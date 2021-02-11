using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        var pair = AdventOfCode.Day1.FindPair();
        if (pair != null)
            Console.WriteLine("pair product = {0}", pair.Item1 * pair.Item2);
        var triplet = AdventOfCode.Day1.FindTriplet();
        if (triplet != null)
            Console.WriteLine("triplet product = {0}", triplet.Item1 * triplet.Item2 * triplet.Item3);
        var valid_count = AdventOfCode.Day2.GetValidCount();
        Console.WriteLine("valid password count = {0}", valid_count);
        var tree_count_r1 = AdventOfCode.Day3.FindTrees(1, 1);
        var tree_count_r2 = AdventOfCode.Day3.FindTrees(3, 1);
        var tree_count_r3 = AdventOfCode.Day3.FindTrees(5, 1);
        var tree_count_r4 = AdventOfCode.Day3.FindTrees(7, 1);
        var tree_count_r5 = AdventOfCode.Day3.FindTrees(1, 2);
        Console.WriteLine("product of tree counts = {0}", tree_count_r1 * tree_count_r2 * tree_count_r3 * tree_count_r4 * tree_count_r5);
        var valid_passport_count = AdventOfCode.Day4.GetValidPassportCount();
        Console.WriteLine("valid passport count = {0}", valid_passport_count);
    }


}
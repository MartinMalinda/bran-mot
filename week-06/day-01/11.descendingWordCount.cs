using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllText(@"./wiki.txt");
            var wikiWords = text.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            var wordCount = wikiWords.GroupBy(word => word).OrderByDescending(word => word.Count()).ToList();
            wordCount.ForEach(word => Console.WriteLine(word.Key + ": " + word.Count()));
        }
    }
}

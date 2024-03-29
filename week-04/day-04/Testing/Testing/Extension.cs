﻿using System;
using System.Collections.Generic;

namespace Testing
{
    public class Extension
    {
        public int Add(int a, int b)
        {
            //return 5; old return
            return a + b;
        }

        public int MaxOfThree(int a, int b, int c)
        {
            if (a > b && a > c)
                return a;
            else if (a < b && b > c)
                return b;
            else
                return c;
        }

        public int Median(List<int> pool)
        {
            pool.Sort();
            return pool[(pool.Count - 1) / 2];
        }

        public bool IsVowel(char c)
        {
            return (new List<char>() { 'a', 'u', 'o', 'e', 'i' }).Contains(c);
        }

        public string Translate(string hungarian)
        {
            string teve = hungarian;
            int length = teve.Length;
            for (int i = 0; i < length; i++)
            {
                char c = teve[i];
                if (IsVowel(c))
                {
                    teve = string.Join(c + "v" + c, teve.Split(c));
                    i += 2;
                    length += 2;
                }
            }
            return teve;
        }
    }
}
// Check out the folder. There's a work file and a test file.

//  -  Run the tests, all 10 should be green (passing).
//  -  The implementations though are not quite good.
//  -  Create tests that'll fail, and will show how the implementations are wrong(You can assume that the implementation of join and split are good)
//  -  After creating the tests, fix the implementations
//  -  Check again, if you can create failing tests
//  -  Implement if needed
using System;
using System.Collections.Generic;

namespace Practice_C_sharp
{
    class Program
    { 
        // center align each word. each line has a single word
        public static void task1_variant1(string text, int linesz)
        {
            string[] words = text.Split("\n");
            foreach(string w in words)
            {
                int req = (linesz - w.Length) / 2;
                while(req > 0)
                {
                    Console.Write(" ");
                    req--;
                }

                Console.WriteLine(w);
            }
        }

        // center align. each line has a single word. if word size exceeds linesz then break it and the align the
        // broken part on the next line
        public static void task1_variant2(string text, int linesz)
        {
            int i;
            string[] words = text.Split("\n");
            foreach (string w in words)
            {
                i = 0;
                while(w.Length - i >= linesz)
                {
                    for (int j = i; j < linesz + i; j++)
                        Console.Write(w[j]);

                    Console.WriteLine();
                    i += linesz;
                }

                int req = (linesz - w.Length + i) / 2;
                while (req > 0)
                {
                    Console.Write(" ");
                    req--;
                }

                for (int j = i; j < w.Length; j++)
                    Console.Write(w[i]);

                Console.WriteLine();
            }
        }
        
        // center align. line can have more than one words. if a words can't be placed in the line completely
        // place it on the next line
        public static void task1_variant3(string text, int linesz)
        {
            
        }

        // center align. each line maybe have more than one words. each word should be in a single line
        public static void task1_variant4(string text, int linesz)
        {
            string[] words = text.Split(new char[] { ' ', '\n' });
            foreach (string w in words)
            {
                int req = (linesz - w.Length) / 2;
                while (req > 0)
                {
                    Console.Write(" ");
                    req--;
                }

                Console.WriteLine(w);
            }
        }

        
    }
}

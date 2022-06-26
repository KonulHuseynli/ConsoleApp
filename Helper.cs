using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp88
{
   public class Helper
    {
        public static void PrintColor(string text,ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }


        public static void PrintFormat(string text,ConsoleColor color)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.ForegroundColor = color;
                Console.Write(text[i]);
                Thread.Sleep(120);
                Console.ResetColor();
            }
        }
      
    }
}

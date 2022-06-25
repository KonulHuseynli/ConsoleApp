using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;
namespace ConsoleApp88
{
   static class TextAnimationUtils
    {
        public static bool CursorVisible { get; private set; }

        public static void Animation(string text)
        {
            int animationcount = 1;
            
            CursorVisible = false;
            for (int i = 0; i < animationcount; i++)
            {
              
                Console.WriteLine(text);
                Thread.Sleep(500);
               Clear();
                Thread.Sleep(200);
              
            }
            Console.WriteLine(text);
            CursorVisible = true;
        }

       
    }
}

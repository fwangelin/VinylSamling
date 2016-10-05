using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class GraphicsForUserMoreLikelyToUseTheProgramOften
    {
        public static void StartApplicationScreenColors()
        {
            Console.WindowWidth = 110;
            Console.WindowHeight = 30;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
        }

        public static void AddingSpaceSoThatGraphicsLooksNicer()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

        }

        public static void ShowStartMenuGraphics()
        {
            Console.Clear();
            AddingSpaceSoThatGraphicsLooksNicer();
            Console.WriteLine("*******************************************************".PadLeft(80));
            Console.WriteLine("*******************************************************".PadLeft(80));
            Console.WriteLine("***                 Choose one option               ***".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("***              1.Add New record                   ***".PadLeft(80));
            Console.WriteLine("***              2.Show record list                 ***".PadLeft(80));
            Console.WriteLine("***              3.Edit records                     ***".PadLeft(80));
            Console.WriteLine("***              4.Quit App                         ***".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("***        To choose one option type in a number    ***".PadLeft(80));
            Console.WriteLine("***                  between 1 and 4                ***".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("*******************************************************".PadLeft(80));
            Console.WriteLine("*******************************************************".PadLeft(80));

        }

    }
}

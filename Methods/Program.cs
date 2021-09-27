using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {

        static int score;
        static string name;
        static int xp;

        static void Main(string[] args)
        {
            Console.WriteLine("Methods");
            Console.WriteLine("/---------------/");
            Console.WriteLine();

            // initialize
            score = 0;
            name = "Lucas";
            xp = 0;

            ShowHUD();

            Console.ReadKey(true);
        }

        //Method to print HUD
        static void ShowHUD()
        {
            Console.WriteLine("{========HUD=======}");
            Console.WriteLine();
            Console.WriteLine("score = " + score);
            Console.WriteLine("name = " + name);
            Console.WriteLine("xp = " + xp);
            Console.WriteLine();
            Console.WriteLine("{==================}");



        }
    }
}

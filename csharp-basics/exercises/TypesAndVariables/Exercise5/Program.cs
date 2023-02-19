using System;

namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var teachJavascript = "Andis";
            var classJavascript = "Javascript";

            var teachBigBoss = "Sandris";
            var classBigBoss = "Discord";

            var teachCSharp = "Edgars";
            var classCSharp = "C#";

            var teachGit = "Līva";
            var classGit = "Github";

            var teachAdmin = "Baiba";
            var classAdmin = "Admin";

            int[] idNr = {1, 2, 3, 4, 5};


            Console.WriteLine("{0, -6 }{1, -6 } {2, -7 } {3, -7 }", "+------------", "-----------------------------------+", "", "");
            Console.WriteLine("{0, -6 }{1, -6 } {2, -20 } {3, 6 }{4, 8 }", "|", "ID", "Class", "Teacher", "|");
            Console.WriteLine("{0, -6 }{1, -6 } {2, 7 }", "|", "-----------------------------------", "|");
            Console.WriteLine("{0, -6 }{1, -6 } {2, -20 } {3, 6 }{4, 9 }", "|", idNr[0], classJavascript, teachJavascript, "|");
            Console.WriteLine("{0, -6 }{1, -6 } {2, -20 } {3, 6 }{4, 8 }", "|", idNr[1], classBigBoss, teachBigBoss, "|");
            Console.WriteLine("{0, -6 }{1, -6 } {2, -20 } {3, 6 }{4, 9 }", "|", idNr[2], classCSharp, teachCSharp, "|");
            Console.WriteLine("{0, -6 }{1, -6 } {2, -20 } {3, 6 }{4, 9 }", "|", idNr[3], classGit, teachGit, "|");
            Console.WriteLine("{0, -6 }{1, -6 } {2, -20 } {3, 6 }{4, 9 }", "|", idNr[4], classAdmin, teachAdmin, "|");

            Console.WriteLine("{0, -6 }{1, -6 } {2, -7 } {3, -7 }{4, 21 }", "|", "", "", "", "|");

            Console.WriteLine("{0, -6 }{1, -6 } {2, -7 } {3, -7 }{4, -7 }", "+------------", "-----------------------------------+", "", "", "");

            Console.ReadKey();

        }
    }
}

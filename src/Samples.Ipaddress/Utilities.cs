// -----------------------------------------------------------------------
// <copyright file="Util.cs" company="apifiedsignature">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Samples.Ipaddress
{
    using System;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    internal static class Utilities
    {
        internal static void ShowMenu(string title)
        {
            ShowMenu(title, null);
        }

        internal static void ShowMenu(String title, string[] collection)
        {
            Console.Clear();

            int width = Console.WindowWidth - 4;
            int i = 0;
            Console.WriteLine("+" + new string('-', width - 2) + "+");
            Console.WriteLine("|" + CenterText(title, width - 2) + "|");
            Console.WriteLine("|" + new string(' ', width - 2) + "|");
            if (collection != null)
            {
                foreach (var item in collection)
                {
                    i++;
                    Console.WriteLine("| " + AlignLeftText(i + ")  " + item, width - 3) + "|");
                }
                Console.WriteLine("| " + AlignLeftText("0. Exit", width - 3) + "|");
            }
            Console.WriteLine("|" + new string(' ', width - 2) + "|");
            Console.WriteLine("+" + new string('-', width - 2) + "+");
        }

        internal static void PrintLabel(string label, string value)
        {
            Console.WriteLine("\t{0}\t{1}",label,value);
        }


        internal static string Scanf(string message)
        {
            Console.Write("\t[ " + message + " ]\t");
            return Console.ReadLine();
        }

        internal static void Pause()
        {
            Console.WriteLine();
            Console.WriteLine("\tPress [Enter] to continue...");
            Console.ReadLine();
        }

        internal static void PrintMessage(string message)
        {
            Console.WriteLine();
            Console.WriteLine("\t+--------------------------------------+");
            Console.WriteLine("\t|" + message);
            Console.WriteLine("\t+--------------------------------------+");
            Console.WriteLine();
        }

        static string CenterText(string text, int width)
        {
            if (text.Length >= width)
                return text.Substring(0, width); // Truncate if text is longer than width

            int spaces = width - text.Length;
            int padLeft = spaces / 2;
            int padRight = spaces - padLeft;

            return new string(' ', padLeft) + text + new string(' ', padRight);
        }

        static string AlignLeftText(string text, int width)
        {
            if (text.Length >= width)
                return text.Substring(0, width); // Truncate if text is longer than width

            int spaces = width - text.Length;
            return text + new string(' ', spaces);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleZone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            ZoneRenderer zoneRenderer = new ZoneRenderer();

            for (int i = 0; i <= 100; i++)
            {
                zoneRenderer.AddString(new ConsoleString($"N {i}", 20, ConsoleColor.Black, ConsoleColor.White), false);
            }

            zoneRenderer.Refresh();
            Console.ReadLine();
            
            foreach (ConsoleString consoleString in zoneRenderer.ConsoleStrings)
            {
                consoleString.Clear();
            }

            zoneRenderer.Refresh();
            Console.ReadLine();
        }
    }
}

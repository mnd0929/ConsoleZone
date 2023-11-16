using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleZone
{
    public class ZoneRenderer
    {
        public Point StartCursorPosition = new Point(0, 0);
        public List<ConsoleString> ConsoleStrings = new List<ConsoleString>();
        public bool ConsoleClear = false;

        //
        // autoRefresh не для большого кол-ва строк!
        public ZoneRenderer AddString(ConsoleString consoleString, bool autoRefresh = true) 
        {
            ConsoleStrings?.Add(consoleString);
            if (autoRefresh) 
                this.Refresh();
            return this;
        }

        //
        // Принудительная перерисовка коллекции ConsoleString в консоли
        public void Refresh() 
        {
            Console.SetCursorPosition(StartCursorPosition.X, StartCursorPosition.Y);

            if (ConsoleClear) Console.Clear();

            foreach (ConsoleString consoleString in ConsoleStrings) 
            {
                if (consoleString.Location != null)
                    Console.SetCursorPosition(consoleString.Location.X, consoleString.Location.Y);

                if (consoleString.Width.HasValue)
                {
                    for (int i = consoleString.Text.Length; i < consoleString.Width; i++)
                    {
                        consoleString.Text += " ";
                    }
                }

                ColorConsole.WriteLine(consoleString.Text, consoleString.ForeColor, consoleString.BackColor);
            }
        }
    }
}

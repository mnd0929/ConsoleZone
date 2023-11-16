using System;

namespace ConsoleZone
{
    public class ConsoleString
    {
        public string Text { get; set; }
        public Point Location { get; set; }
        public int? Width { get; set; }
        public ConsoleColor ForeColor = DefaultConsoleString.ForeColor;
        public ConsoleColor BackColor = DefaultConsoleString.BackColor;
        public void ClearText()
        {
            string NewText = null;
            for (int i = 0; i < Text.Length; i++)
            {
                NewText += " ";
            }
            Text = NewText;
        }
        public void Clear()
        {
            ClearText();
            this.BackColor = Console.BackgroundColor;
            this.ForeColor = Console.ForegroundColor;

            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
        public void Refresh()
        {
            if (this.Location != null)
                Console.SetCursorPosition(Location.X, Location.Y);

            ColorConsole.WriteLine(Text, ForeColor, BackColor);
        }
        public ConsoleString() { }
        public ConsoleString(string text) { Text = text; }
        public ConsoleString(string text, int width) { Text = text; Width = width; }
        public ConsoleString(string text, Point location) { Text = text; Location = location; }
        public ConsoleString(string text, Point location, int width) { Text = text; Location = location; Width = width; }
        public ConsoleString(string text, Point location, ConsoleColor foreColor) 
        { 
            Text = text; 
            Location = location;
            ForeColor = foreColor;
        }
        public ConsoleString(string text, int width, ConsoleColor foreColor)
        {
            Text = text;
            Width = width;
            ForeColor = foreColor;
        }
        public ConsoleString(string text, Point location, ConsoleColor foreColor, ConsoleColor backColor)
        {
            Text = text;
            Location = location;
            ForeColor = foreColor;
            BackColor = backColor;
        }
        public ConsoleString(string text, int width, ConsoleColor foreColor, ConsoleColor backColor)
        {
            Text = text;
            Width = width;
            ForeColor = foreColor;
            BackColor = backColor;
        }
        public ConsoleString(string text, ConsoleColor foreColor, ConsoleColor backColor)
        {
            Text = text;
            ForeColor = foreColor;
            BackColor = backColor;
        }
    }
    public static class DefaultConsoleString
    {
        public static ConsoleColor ForeColor = Console.ForegroundColor;
        public static ConsoleColor BackColor = Console.BackgroundColor;
    }
}

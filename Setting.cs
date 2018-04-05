using System;
namespace deckcards
{
    public static class Setting 
    {
        public static string[] Menu = {
                " 1 : Shuffle",
                " 2 : Deal",
                " 3 : Input the number of players",
                " 4 : Display all cards",
                " 9 : Reset all cards",
                " 0 : Exit"
            };
        public static string UpperLeftCorner = "╔";
        public static string LowerLeftCorner = "╚";
        public static string UpperRightCorner = "╗";
        public static string LowerRightCorner = "╝";
        public static string vertical = "║";
        public static string horizontal = "═";
        public static string dash = "-";
        public static int LeftSpace = 10;
        public static int LineWidth = 50;

        public static ConsoleColor DashLineColor = ConsoleColor.DarkCyan;
        public static ConsoleColor MenuColor = ConsoleColor.Green;
        public static ConsoleColor ClubsColor = ConsoleColor.Blue;
        public static ConsoleColor DiamondsColor = ConsoleColor.DarkYellow;
        public static ConsoleColor HeartsColor = ConsoleColor.Red;
        public static ConsoleColor SpadesColor = ConsoleColor.Cyan;

    }
}
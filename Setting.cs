using System;
namespace deckcards
{
    public static class Setting 
    {
        public static string[] Menu = {
                " 1 : Input the player name",
                " 4 : Display all cards",
                " 5 : Display all players",
                " 6 : Start",
                " 9 : Reset all cards",
                " 0 : Exit"
            };

        public static string[] MenuPlayer = {
            " 0 : Exit ",
            " 1 - 5: To use the card to attack",
            " 6 : To use Samurai's Attack",
            " 7 : To use Samurai's Death Blow",
            " 8 : Meditate",
        };

        public static string[] AttactInfo = {
            "Card value 2 to 5 will cost 1 energy and will deal a random damage from 10 to 20",
            "Card value 6 to 10 will cost 1 energy and will deal a random damage from 20 to 40",
            "Card value A to 5 will cost 1 energy and will deal a random damage from 10 to 20",
        };
        public static string UpperLeftCorner = "╔";
        public static string LowerLeftCorner = "╚";
        public static string UpperRightCorner = "╗";
        public static string LowerRightCorner = "╝";
        public static string vertical = "║";
        public static string horizontal = "═";
        public static string dash = "-";
        public static int LeftSpace = 20;
        public static int LineWidth = 50;

        public static ConsoleColor DashLineColor = ConsoleColor.DarkCyan;
        public static ConsoleColor MenuColor = ConsoleColor.Green;
        public static ConsoleColor ClubsColor = ConsoleColor.Blue;
        public static ConsoleColor DiamondsColor = ConsoleColor.DarkYellow;
        public static ConsoleColor HeartsColor = ConsoleColor.Red;
        public static ConsoleColor SpadesColor = ConsoleColor.Cyan;

        public static ConsoleColor WarningColor = ConsoleColor.Red;

    }
}
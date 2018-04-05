using System;

namespace deckcards {
        public static class Utils {
            //Drawing Utilities
            public static void WriteSpace(int num)
            {
                for (int i = 0; i < num; i++)
                {
                    System.Console.Write(" ");
                }
            }
            public static void Write(string str)
            {
                System.Console.Write(str);
            }

            public static void Write(string str, int num)
            {
                for (int i = 0; i < num; i++)
                {
                    System.Console.Write(str);
                }
            }

            public static void WriteLine(int num)
            {
                for (int i = 0; i < num; i++)
                {
                    System.Console.Write(Setting.horizontal);
                }
            }
            public static void WriteDash(int num)
            {
                for (int i = 0; i < num; i++)
                {
                    System.Console.Write(Setting.dash);
                }
            }
            public static void WriteDashLine()
            {
                //Dash Line
                WriteSpace(Setting.LeftSpace);
                Write(Setting.vertical);
                Console.ForegroundColor = Setting.DashLineColor;
                WriteDash(Setting.LineWidth);
                Console.ForegroundColor = Setting.MenuColor;
                Write(Setting.vertical);
                System.Console.WriteLine();
            }
            //Drawing Utilities

            public static void WriteWarning(string str)
            {
                Console.ForegroundColor = Setting.WarningColor;
                System.Console.WriteLine(str);
                Console.ResetColor();
            }
            

        }
}
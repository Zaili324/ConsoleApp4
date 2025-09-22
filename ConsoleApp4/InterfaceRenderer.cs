using System;

namespace NortonCommander
{
    public static class InterfaceRenderer
    {
        const int WINDOW_WIDTH = 80;
        const int WINDOW_HEIGHT = 26;
        const int LEFT_PANEL_WIDTH = 39;
        const int RIGHT_PANEL_WIDTH = 39;

        // Символы псевдографики
        const char HORIZONTAL_LINE = '─';
        const char VERTICAL_LINE = '│';
        const char TOP_LEFT_CORNER = '┌';
        const char TOP_RIGHT_CORNER = '┐';
        const char BOTTOM_LEFT_CORNER = '└';
        const char BOTTOM_RIGHT_CORNER = '┘';
        const char T_DOWN = '┬';
        const char T_UP = '┴';
        const char T_RIGHT = '├';
        const char T_LEFT = '┤';
        const char CROSS = '┼';

        // Двойные границы
        const char DOUBLE_VERTICAL_LINE = '║';
        const char DOUBLE_HORIZONTAL_LINE = '═';
        const char DOUBLE_TOP_LEFT_CORNER = '╔';
        const char DOUBLE_TOP_RIGHT_CORNER = '╗';
        const char DOUBLE_BOTTOM_LEFT_CORNER = '╚';
        const char DOUBLE_BOTTOM_RIGHT_CORNER = '╝';
        const char DOUBLE_T_DOWN = '╦';
        const char DOUBLE_T_UP = '╩';
        const char DOUBLE_T_RIGHT = '╠';
        const char DOUBLE_T_LEFT = '╣';
        const char DOUBLE_CROSS = '╬';
        const char DOUBLE_BOTTOM_RIGHT_CORNER_TOP = '\u2562';
        const char DOUBLE_BOTTOM_LEFT_CORNER_TOP = '\u255F';

        public static void DrawInterface()
        {
            DrawTopBackgroundColor();
            DrawTopPanel();
            DrawMainPanels();
            DrawBottomPanel();
            DrawLowPanel();
            DrawTopPanelTime();
        }

        static void DrawLowPanel()
        {
            Console.SetCursorPosition(0, 25);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("1");

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Помощь");

            Console.SetCursorPosition(7, 25);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" 2");

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Вызов");

            Console.SetCursorPosition(14, 25);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" 3");

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Чтение");

            Console.SetCursorPosition(22, 25);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" 4");

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Правка");

            Console.SetCursorPosition(30, 25);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" 5");

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Копия ");

            Console.SetCursorPosition(38, 25);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" 6");

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("НовИмя");

            Console.SetCursorPosition(46, 25);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" 7");

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("НовКат");

            Console.SetCursorPosition(54, 25);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" 8");

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Удал-е");

            Console.SetCursorPosition(62, 25);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" 9");

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Меню  ");

            Console.SetCursorPosition(70, 25);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" 10");

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Выход  ");
        }

        static void DrawTopPanel()
        {
            Console.SetCursorPosition(4, 0);
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Л");

            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("евая");

            Console.SetCursorPosition(15, 0);
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Ф");

            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("айл");

            Console.SetCursorPosition(24, 0);
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Д");

            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("иск");

            Console.SetCursorPosition(32, 0);
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("К");

            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("оманды");

            Console.SetCursorPosition(44, 0);
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("П");

            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("равая");
        }

        static void DrawTopBackgroundColor()
        {
            Console.SetCursorPosition(0, 0);
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(new string(' ', WINDOW_WIDTH));
        }

        static void DrawTopPanelTime()
        {
            Console.SetCursorPosition(76, 0);
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Blue;

            string[] functime = { "8 30", };
            string topLime = string.Join(" ", functime);
            Console.Write(topLime);
        }

        static void DrawMainPanels()
        {
            DrawLeftPanel();
            DrawRightPanel();
            DrawLeftPanel2();
            DrawRightPanel2();
            DrawLeftPanel3();
            DrawLeftPanel4();
            DrawRightPanel3();
            DrawRightPanel4();
        }

        static void DrawMiddleLine()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 2; i < 22; i++)
            {
                Console.SetCursorPosition(39, i);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(DOUBLE_VERTICAL_LINE);
            }
        }

        static void DrawLeftPanel2()
        {
            Console.SetCursorPosition(50, 1);
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" C:\\NC ");
        }

        static void DrawLeftPanel3()
        {
            Console.SetCursorPosition(68, 1);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\u2564");
            Console.SetCursorPosition(68, 21);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\u2534");
            Console.SetCursorPosition(52, 21);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\u2534");
        }

        static void DrawLeftPanel4()
        {
            Console.SetCursorPosition(59, 1);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\u2564");
            Console.SetCursorPosition(59, 21);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\u2534");
        }

        static void DrawLeftPanel()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(0, 1);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(DOUBLE_TOP_LEFT_CORNER + new string(DOUBLE_HORIZONTAL_LINE, LEFT_PANEL_WIDTH - 4) + DOUBLE_TOP_RIGHT_CORNER);

            Console.SetCursorPosition(0, 2);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(DOUBLE_VERTICAL_LINE);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("C:| Имя".PadRight(11));
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(VERTICAL_LINE);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("    Имя".PadRight(11));
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(VERTICAL_LINE);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("    Имя".PadRight(11));
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(DOUBLE_VERTICAL_LINE);

            int filesPerColumn = (PanelManager.LeftPanelFiles.Count + 3) / 3;
            int currentRow = 3;

            for (int i = 0; i < filesPerColumn && currentRow < 22; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(0, currentRow);
                Console.Write(DOUBLE_VERTICAL_LINE);

                Console.ForegroundColor = ConsoleColor.White;
                if (i < PanelManager.LeftPanelFiles.Count)
                {
                    DrawFileItem(PanelManager.LeftPanelFiles[i], 1, 11);
                }
                else
                {
                    Console.Write(new string(' ', 11));
                }
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(VERTICAL_LINE);

                Console.ForegroundColor = ConsoleColor.White;
                int secondColIndex = i + filesPerColumn;
                if (secondColIndex < PanelManager.LeftPanelFiles.Count)
                {
                    DrawFileItem(PanelManager.LeftPanelFiles[secondColIndex], 13, 11);
                }
                else
                {
                    Console.Write(new string(' ', 11));
                }
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(VERTICAL_LINE);

                Console.ForegroundColor = ConsoleColor.White;
                int thirdColIndex = i + filesPerColumn * 2;
                if (thirdColIndex < PanelManager.LeftPanelFiles.Count)
                {
                    DrawFileItem(PanelManager.LeftPanelFiles[thirdColIndex], 25, 11);
                }
                else
                {
                    Console.Write(new string(' ', 11));
                }
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(DOUBLE_VERTICAL_LINE);

                currentRow++;
            }

            while (currentRow < 22)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(0, currentRow);
                Console.Write(DOUBLE_VERTICAL_LINE + new string(' ', 11) + VERTICAL_LINE + new string(' ', 11) + VERTICAL_LINE + new string(' ', 11) + DOUBLE_VERTICAL_LINE);
                currentRow++;
            }

            Console.SetCursorPosition(0, 22);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(DOUBLE_VERTICAL_LINE + "..          КАТАЛОГ 11.10.02 19.48" + new string(' ', 1) + DOUBLE_VERTICAL_LINE);
            Console.SetCursorPosition(0, 23);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(DOUBLE_BOTTOM_LEFT_CORNER + new string(DOUBLE_HORIZONTAL_LINE, LEFT_PANEL_WIDTH - 4) + DOUBLE_BOTTOM_RIGHT_CORNER);
            Console.SetCursorPosition(0, 21);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(DOUBLE_BOTTOM_LEFT_CORNER_TOP + new string(HORIZONTAL_LINE, RIGHT_PANEL_WIDTH - 4) + DOUBLE_BOTTOM_RIGHT_CORNER_TOP);
        }

        static void DrawRightPanel3()
        {
            Console.SetCursorPosition(12, 1);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\u2564");
            Console.SetCursorPosition(12, 21);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\u2534");
        }

        static void DrawRightPanel4()
        {
            Console.SetCursorPosition(24, 1);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\u2564");
            Console.SetCursorPosition(24, 21);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\u2534");
        }

        static void DrawRightPanel2()
        {
            Console.SetCursorPosition(15, 1);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" C:\\NC ");
        }

        static void DrawRightPanel()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            Console.SetCursorPosition(40, 1);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(DOUBLE_TOP_LEFT_CORNER + new string(DOUBLE_HORIZONTAL_LINE, RIGHT_PANEL_WIDTH - 6) + DOUBLE_TOP_RIGHT_CORNER);

            Console.SetCursorPosition(40, 2);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(DOUBLE_VERTICAL_LINE);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("C:|  Имя   ".PadRight(10));
            Console.Write(VERTICAL_LINE);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Размер".PadLeft(4));
            Console.Write(VERTICAL_LINE);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("  Дата".PadRight(8));
            Console.Write(VERTICAL_LINE);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Время".PadRight(5));
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(DOUBLE_VERTICAL_LINE);

            int currentRow = 3;
            int maxFiles = Math.Min(PanelManager.RightPanelFiles.Count, 17);

            for (int i = 0; i < maxFiles && currentRow < 22; i++)
            {
                Console.SetCursorPosition(40, currentRow);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(DOUBLE_VERTICAL_LINE);

                var file = PanelManager.RightPanelFiles[i];

                Console.ForegroundColor = ConsoleColor.White;
                string fileName = file.GetShortName(10);
                Console.Write(" " + fileName.PadRight(9));
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(VERTICAL_LINE);

                Console.ForegroundColor = ConsoleColor.White;
                string size = file.IsDirectory ? "<DIR>" : file.Size.ToString();
                Console.Write(size.PadLeft(6));
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(VERTICAL_LINE);

                Console.ForegroundColor = ConsoleColor.White;
                string date = file.Modified.ToString("dd.MM.yy");
                Console.Write(date.PadRight(8));
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(VERTICAL_LINE);

                Console.ForegroundColor = ConsoleColor.White;
                string time = file.Modified.ToString("HH:mm");
                Console.Write(time.PadRight(5));
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(DOUBLE_VERTICAL_LINE);

                currentRow++;
            }

            while (currentRow < 22)
            {
                Console.SetCursorPosition(40, currentRow);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(DOUBLE_VERTICAL_LINE + new string(' ', 11) + VERTICAL_LINE + new string(' ', 6) + VERTICAL_LINE + new string(' ', 8) + VERTICAL_LINE + new string(' ', 5) + DOUBLE_VERTICAL_LINE);
                currentRow++;
            }

            Console.SetCursorPosition(40, 22);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(DOUBLE_VERTICAL_LINE + "..        КАТАЛОГ 11.10.02 19:49" + new string(' ', 1) + DOUBLE_VERTICAL_LINE);
            Console.SetCursorPosition(40, 23);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(DOUBLE_BOTTOM_LEFT_CORNER + new string(DOUBLE_HORIZONTAL_LINE, RIGHT_PANEL_WIDTH - 6) + DOUBLE_BOTTOM_RIGHT_CORNER);
            Console.SetCursorPosition(40, 21);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(DOUBLE_BOTTOM_LEFT_CORNER_TOP + new string(HORIZONTAL_LINE, RIGHT_PANEL_WIDTH - 6) + DOUBLE_BOTTOM_RIGHT_CORNER_TOP);
        }

        static void DrawFileItem(FileItem file, int startPos, int width)
        {
            Console.SetCursorPosition(startPos, Console.CursorTop);

            if (file.IsDirectory)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }

            string displayName = file.GetShortName(width - 1);
            Console.Write(displayName.PadRight(width));
        }

        static void DrawBottomPanel()
        {
            Console.SetCursorPosition(0, 24);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("C:\\NC>" + new string(' ', WINDOW_WIDTH - 6));
        }
    }
}
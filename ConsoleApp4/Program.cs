using System;

namespace NortonCommander
{
    class Program
    {
        const int WINDOW_WIDTH = 80;
        const int WINDOW_HEIGHT = 26;

        static void Main(string[] args)
        {
            Console.SetWindowSize(WINDOW_WIDTH, WINDOW_HEIGHT);
            Console.SetBufferSize(WINDOW_WIDTH, WINDOW_HEIGHT);
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            PanelManager.InitializeFileData();
            InterfaceRenderer.DrawInterface();

            Console.ReadKey();
        }
    }
}
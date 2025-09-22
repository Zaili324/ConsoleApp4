using System;
using System.Collections.Generic;
using System.Linq;

namespace NortonCommander
{
    public static class PanelManager
    {
        public static List<FileItem> LeftPanelFiles { get; private set; }
        public static List<FileItem> RightPanelFiles { get; private set; }

        public static void InitializeFileData()
        {
            LeftPanelFiles = new List<FileItem>
            {
                new FileItem("Ajaccgdoc", 0, new DateTime(2024, 5, 25, 5, 0, 0), true),
                new FileItem("cfg", 0, new DateTime(2024, 5, 25, 5, 0, 0), true),
                new FileItem("nc_exit", 175, new DateTime(2024, 5, 25, 5, 0, 0), false, "com"),
                new FileItem(".. ", 128360, new DateTime(2024, 5, 25, 5, 0, 0), false, "exe"),
                new FileItem("bitmap", 41728, new DateTime(2024, 5, 25, 5, 0, 0), false, "exe"),
                new FileItem("dbview", 0, new DateTime(2024, 5, 25, 5, 0, 0), true),
                new FileItem("drawpln", 41728, new DateTime(2024, 5, 25, 5, 0, 0), false, "exe"),
                new FileItem("drc2wmf", 41728, new DateTime(2024, 5, 25, 5, 0, 0), false, "exe"),
                new FileItem("msdb2db", 16183, new DateTime(2024, 5, 25, 5, 0, 0), false, "exe"),
                new FileItem("ncclean", 54405, new DateTime(2024, 5, 25, 5, 0, 0), false, "exe"),
                new FileItem("backup", 0, new DateTime(2024, 5, 25, 5, 0, 0), true),
                new FileItem("config", 1024, new DateTime(2024, 5, 25, 5, 0, 0), false, "sys"),
                new FileItem("data", 20480, new DateTime(2024, 5, 25, 5, 0, 0), false, "dat"),
                new FileItem("docs", 0, new DateTime(2024, 5, 25, 5, 0, 0), true),
                new FileItem("edit", 24576, new DateTime(2024, 5, 25, 5, 0, 0), false, "exe"),
                new FileItem("files", 0, new DateTime(2024, 5, 25, 5, 0, 0), true),
                new FileItem("graphics", 0, new DateTime(2024, 5, 25, 5, 0, 0), true),
                new FileItem("help", 32768, new DateTime(2024, 5, 25, 5, 0, 0), false, "hlp"),
                new FileItem("install", 40960, new DateTime(2024, 5, 25, 5, 0, 0), false, "exe"),
                new FileItem("library", 0, new DateTime(2024, 5, 25, 5, 0, 0), true),
                new FileItem("manual", 51200, new DateTime(2024, 5, 25, 5, 0, 0), false, "doc"),
                new FileItem("notes", 10240, new DateTime(2024, 5, 25, 5, 0, 0), false, "txt"),
                new FileItem("program", 61440, new DateTime(2024, 5, 25, 5, 0, 0), false, "exe"),
                new FileItem("readme", 15360, new DateTime(2024, 5, 25, 5, 0, 0), false, "txt"),
                new FileItem("setup", 28672, new DateTime(2024, 5, 25, 5, 0, 0), false, "exe"),
                new FileItem("temp", 0, new DateTime(2024, 5, 25, 5, 0, 0), true),
                new FileItem("utils", 0, new DateTime(2024, 5, 25, 5, 0, 0), true),
                new FileItem("windows", 0, new DateTime(2024, 5, 25, 5, 0, 0), true),
                new FileItem("system", 0, new DateTime(2024, 5, 25, 5, 0, 0), true),
                new FileItem("drivers", 0, new DateTime(2024, 5, 25, 5, 0, 0), true),
                new FileItem("bin", 0, new DateTime(2024, 5, 25, 5, 0, 0), true),
                new FileItem("lib", 0, new DateTime(2024, 5, 25, 5, 0, 0), true),
                new FileItem("src", 0, new DateTime(2024, 5, 25, 5, 0, 0), true),
                new FileItem("tmp", 0, new DateTime(2024, 5, 25, 5, 0, 0), true),
                new FileItem("log", 0, new DateTime(2024, 5, 25, 5, 0, 0), true),
                new FileItem("cache", 0, new DateTime(2024, 5, 25, 5, 0, 0), true),
                new FileItem("backups", 0, new DateTime(2024, 5, 25, 5, 0, 0), true),
                new FileItem("downloads", 0, new DateTime(2024, 5, 25, 5, 0, 0), true),
                new FileItem("documents", 0, new DateTime(2024, 5, 25, 5, 0, 0), true),
                new FileItem("pictures", 0, new DateTime(2024, 5, 25, 5, 0, 0), true),
                new FileItem("music", 0, new DateTime(2024, 5, 25, 5, 0, 0), true),
                new FileItem("videos", 0, new DateTime(2024, 5, 25, 5, 0, 0), true),
                new FileItem("projects", 0, new DateTime(2024, 5, 25, 5, 0, 0), true),
                new FileItem("work", 0, new DateTime(2024, 5, 25, 5, 0, 0), true),
                new FileItem("personal", 0, new DateTime(2024, 5, 25, 5, 0, 0), true)
            };

            RightPanelFiles = new List<FileItem>
            {
                new FileItem("123view.exe", 128360, new DateTime(2024, 5, 25, 5, 0, 0)),
                new FileItem("Mxinit2.set", 255, new DateTime(2024, 5, 25, 5, 0, 0)),
                new FileItem("852ansi.set", 255, new DateTime(2024, 5, 25, 5, 0, 0)),
                new FileItem("852ibm.set", 255, new DateTime(2024, 5, 25, 5, 0, 0)),
                new FileItem("866rus.set", 255, new DateTime(2024, 5, 25, 5, 0, 0)),
                new FileItem("866ansi.set", 255, new DateTime(2024, 5, 25, 5, 0, 0)),
                new FileItem("acccode/set", 41728, new DateTime(2024, 5, 25, 5, 0, 0)),
                new FileItem("ansi2437.set", 255, new DateTime(2024, 5, 25, 5, 0, 0)),
                new FileItem("ansi850.set", 255, new DateTime(2024, 5, 25, 5, 0, 0)),
                new FileItem("ansi2863.set", 255, new DateTime(2024, 5, 25, 5, 0, 0)),
                new FileItem("ansi860.set", 255, new DateTime(2024, 5, 25, 5, 0, 0)),
                new FileItem("ansi2866.set", 255, new DateTime(2024, 5, 25, 5, 0, 0)),
                new FileItem("bugfil.exe", 41728, new DateTime(2024, 5, 25, 5, 0, 0)),
                new FileItem("bitmap.exe", 54405, new DateTime(2024, 5, 25, 5, 0, 0)),
                new FileItem("bungee.nss", 16183, new DateTime(2024, 5, 25, 5, 0, 0)),
                new FileItem("config.sys", 1024, new DateTime(2024, 5, 25, 5, 0, 0)),
                new FileItem("autoexec.bat", 2048, new DateTime(2024, 5, 25, 5, 0, 0)),
                new FileItem("command.com", 54619, new DateTime(2024, 5, 25, 5, 0, 0))
            };

            LeftPanelFiles = LeftPanelFiles.OrderBy(f => f.Name).ToList();
            RightPanelFiles = RightPanelFiles.OrderBy(f => f.Name).ToList();
        }
    }
}
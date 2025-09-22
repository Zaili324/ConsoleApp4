using System;

namespace NortonCommander
{
    public class FileItem
    {
        public string Name { get; set; }
        public long Size { get; set; }
        public DateTime Modified { get; set; }
        public bool IsDirectory { get; set; }
        public string Extension { get; set; }

        public FileItem(string name, long size, DateTime modified, bool isDirectory = false, string extension = "")
        {
            Name = name;
            Size = size;
            Modified = modified;
            IsDirectory = isDirectory;
            Extension = extension;
        }

        public string GetShortName(int maxLength)
        {
            if (Name.Length <= maxLength)
                return Name;

            if (Extension.Length > 0 && maxLength > Extension.Length + 2)
            {
                int nameLength = maxLength - Extension.Length - 2;
                return Name.Substring(0, nameLength) + "~." + Extension;
            }
            else
            {
                return Name.Substring(0, maxLength - 1) + "~";
            }
        }
    }
}
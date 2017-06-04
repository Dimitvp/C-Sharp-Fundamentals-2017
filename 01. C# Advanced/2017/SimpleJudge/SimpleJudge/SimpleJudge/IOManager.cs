using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleJudge
{
    public static class IOManager
    {
        public static void CreateDirectoryInCurrentFolder(string name)
        {
            string path = Directory.GetCurrentDirectory() + "\\" + name;
            Directory.CreateDirectory(path);
        }

        public static void TraverseDirectory(int depth)
        {
            OutputWriter.WriteEmptyLine();
            int initialIdentation = SessionData.currentPath.Split('\\').Length;
            Queue<string> subFolders = new Queue<string>();
            subFolders.Enqueue(SessionData.currentPath);

            foreach (var file in Directory.GetFiles(currentPath))
            {
                int indexOfLastSlash = file.LastIndexOf("\\");
                string fileName = file.Substring(indexOfLastSlash);
                OutputWriter.WriteMessageOnNewLine(new string('-', indexOfLastSlash) + fileName);
            }
        }

    }
}

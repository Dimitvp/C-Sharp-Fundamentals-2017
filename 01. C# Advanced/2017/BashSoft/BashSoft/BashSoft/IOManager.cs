using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace BashSoft
{
    public static class IOManager
    {
        public static void TraverseDirectory(string path)
        {
            OutputWriter.WriteEmptyLine();
            int initialIdention = path.Split('\\').Length;
            Queue<string> subFolders = new Queue<string>();
            subFolders.Enqueue(path);

            while (subFolders.Count != 0)
            {
                //TODO Dequeue the folder at the start ot the queue
                string currentPath = subFolders.Dequeue();
                int identation = currentPath.Split('\\').Length - initialIdention;

                //TODO Ptint the folder path
                OutputWriter.WriteMessageOnNewLine(string.Format("{0}{1}", new string('-', identation), currentPath));

                foreach (var VARIABLE in Directory.GetDirectories(currentPath))
                {
                    //TODO Add it`s subfolders to the end of the queue
                }
            }
        }
    }
}

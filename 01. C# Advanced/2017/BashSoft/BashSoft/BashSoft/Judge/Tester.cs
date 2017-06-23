using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BashSoft;

namespace SimpleJudge
{
    public static class Tester
    {
        public static void CompareContent(string userOutputPath, string expectOutputPath)
        {
            try
            {
                OutputWriter.WriteMessageOnNewLine("Reading files...");
                string mismatchPath = GetMismatchPath(expectOutputPath);

                string[] actualOutputLines = File.ReadAllLines(userOutputPath);
                string[] expectedOutputLines = File.ReadAllLines(expectOutputPath);

                bool hasMismatch;
                string[] mismatchs = GetLinesWithPossibleMismatches(actualOutputLines, expectedOutputLines,
                    out hasMismatch);

                PrintOutput(mismatchs, hasMismatch, mismatchPath);
                OutputWriter.WriteMessageOnNewLine("Files read!");
            }
            catch (FileNotFoundException)
            {
                OutputWriter.DisplayException(ExceptionMessages.InvalidPath);
            }
        }

        private static void PrintOutput(string[] mismatchs, bool hasMismatch, string mismatchPath)
        {
            if (hasMismatch)
            {
                foreach (var line in mismatchs)
                {
                    OutputWriter.WriteMessageOnNewLine(line);
                }
                try
                {
                    File.WriteAllLines(mismatchPath, mismatchs);
                }
                catch (DirectoryNotFoundException)
                {
                    OutputWriter.DisplayException(ExceptionMessages.InvalidPath);
                }
                return;

            }
            OutputWriter.WriteMessageOnNewLine("Files are identical. There are no mismatches.");
        }

        private static string[] GetLinesWithPossibleMismatches(string[] actualOutputLines, string[] expectedOutputLines, out bool hasMismatch)
        {
            hasMismatch = false;
            string output = string.Empty;
            
            OutputWriter.WriteMessageOnNewLine("Comparing files");

            int minOutputLines = actualOutputLines.Length;
            if (actualOutputLines.Length != expectedOutputLines.Length)
            {
                hasMismatch = true;
                minOutputLines = Math.Min(actualOutputLines.Length, expectedOutputLines.Length);
                OutputWriter.DisplayException(ExceptionMessages.ComparisonOfFilesWithDifferentSizes);
            }

            string[] mismatchs = new string[minOutputLines];

            for (int index = 0; index < minOutputLines; index++)
            {
                string actualLine = actualOutputLines[index];
                string expectedLine = expectedOutputLines[index];
                if (!actualLine.Equals(expectedLine))
                {
                    output = string.Format("Mismatch at line {0} -- expected: \"{1}\", actual: \"{2}\"", index, expectedLine, actualLine);
                    output += Environment.NewLine;
                    hasMismatch = true;
                }
                else
                {
                    output = actualLine;
                    output += Environment.NewLine;
                }

                mismatchs[index] = output;
            }
            return mismatchs;
        }

        private static string GetMismatchPath(string expextedOutputPath)
        {
            int indexOf = expextedOutputPath.LastIndexOf('\\');
            string directoryPath = expextedOutputPath.Substring(0, indexOf);
            string finalPath = directoryPath + @"\Mismatches.txt";
            return finalPath;
        }
    }
}

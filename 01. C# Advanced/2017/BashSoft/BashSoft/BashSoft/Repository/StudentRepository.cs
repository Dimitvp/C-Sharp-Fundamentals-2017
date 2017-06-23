﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using SimpleJudge;

namespace BashSoft
{
    public static class StudentRepository
    {
        public static bool isDataInitialized = false;
        private static Dictionary<string, Dictionary<string, List<int>>> studentByCourse;

        public static void InitializeData(string fileName)
        {
            if (!isDataInitialized)
            {
                OutputWriter.WriteMessageOnNewLine("Reading data...");
                studentByCourse = new Dictionary<string, Dictionary<string, List<int>>>();
                ReadData(fileName);
            }
            else
            {
                OutputWriter.WriteMessageOnNewLine(ExceptionMessages.DataAlreadyInitialisedException);
            }
        }

        public static void FilterAndTake(string courseName, string givenFilter, int? studentsToTake = null)
        {
            if (IsQueryForCoursePossible(courseName))
            {
                if (studentsToTake == null)
                {
                    studentsToTake = studentByCourse[courseName].Count;
                }
                RepositoryFilters.FilterAndTake(studentByCourse[courseName], givenFilter, studentsToTake.Value);
            }
        }

        public static void OrderAndTake(string courseName, string comparison, int? studentsToTake = null)
        {
            if (IsQueryForCoursePossible(courseName))
            {
                if (studentsToTake == null)
                {
                    studentsToTake = studentByCourse[courseName].Count;
                }
                RepositorySorters.OrderAndTake(studentByCourse[courseName], comparison, studentsToTake.Value);
            }
        }

        private static void ReadData(string fileName)
        {
            
            string path = SessionData.currentPath + "\\" + fileName;
            if (File.Exists(path))
            {
                string pattern = @"([A-Z][a-zA-Z#+]*_[A-Z][a-z]{2}_\d{4})\s+([A-Z][a-z]{0,3}\d{2}_\d{2,4})\s+(\d+)";
                Regex rgx = new Regex(pattern);
                string[] allInputLines = File.ReadAllLines(path);
                for (int line = 0; line < allInputLines.Length; line++)
                {
                    
                    if (!string.IsNullOrEmpty(allInputLines[line]) && rgx.IsMatch(allInputLines[line]))
                    {
                        Match currentMatch = rgx.Match(allInputLines[line]);
                        string courseName = currentMatch.Groups[1].Value;
                        string username = currentMatch.Groups[2].Value;
                        int studentScoreOnTask;
                        bool hasParsedScore = int.TryParse(currentMatch.Groups[3].Value, out studentScoreOnTask);

                        if (hasParsedScore && studentScoreOnTask >= 0 && studentScoreOnTask <= 100)
                        {
                            if (!studentByCourse.ContainsKey(courseName))
                            {
                                studentByCourse.Add(courseName, new Dictionary<string, List<int>>());
                            }
                            //TODO: Add the mark
                            if (!studentByCourse[courseName].ContainsKey(username))
                            {
                                studentByCourse[courseName].Add(username, new List<int>());
                            }

                            studentByCourse[courseName][username].Add(studentScoreOnTask);
                        }

                        string[] data = allInputLines[line].Split(' ');
                    }
                }
            }
            //string input = Console.ReadLine();


            //while (!string.IsNullOrEmpty(input))
            //{
                //string[] tokens = input.Split(' ');
                //string course = tokens[0];
                //string student = tokens[1];
                //int mark = int.Parse(tokens[2]);

                ////TODO: Add the course and student if the don`t exist
                //if (!studentByCourse.ContainsKey(course))
                //{
                //    studentByCourse.Add(course, new Dictionary<string, List<int>>());
                //}
                ////TODO: Add the mark
                //if (!studentByCourse[course].ContainsKey(student))
                //{
                //    studentByCourse[course].Add(student, new List<int>());
                //}

                //studentByCourse[course][student].Add(mark);
                //input = Console.ReadLine();
            //}

            isDataInitialized = true;
            OutputWriter.WriteMessageOnNewLine("Data read!");
        }

        private static bool IsQueryForCoursePossible(string courseName)
        {
            if (isDataInitialized)
            {
                if (studentByCourse.ContainsKey(courseName))
                {
                    return true;
                }
                else
                {
                    OutputWriter.DisplayException(ExceptionMessages.InexistingCourseInDataBase);
                }
                return true;
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.DataNotInitializedExceptionMessage);
            }
            return false;
        }

        private static bool IsQueryForStudentPossuble(string courseName, string studentUserName)
        {
            if (IsQueryForCoursePossible(courseName) && studentByCourse[courseName].ContainsKey(studentUserName))
            {
                return true;
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.InexistingCourseInDataBase);
            }
            return false;
        }

        public static void GetStudentScoresFromCourse(string courseName, string username)
        {
            if (IsQueryForStudentPossuble(courseName, username))
            {
                OutputWriter.PrintStudent(new KeyValuePair<string, List<int>>(username, studentByCourse[courseName][username]));
            }
        }

        public static void GetAllStudentsFromCourse(string courseName)
        {
            if (IsQueryForCoursePossible(courseName))
            {
                OutputWriter.WriteMessageOnNewLine($"{courseName}:");
                foreach (var studentMarksEntry in studentByCourse[courseName])
                {
                    OutputWriter.PrintStudent(studentMarksEntry);
                }
            }
        }
    }
}

namespace BashSoft
{
    class Launcher
    {
        static void Main()
        {
            //IOManager.TraverseDirectory(@"E:\01. SoftUni\6. C# Fundametals\01. C# Advanced\2017\BashSoft\BashSoft");
            StudentRepository.InitializeData();
            StudentRepository.GetStudentScoresFromCourse("Unity", "Ivan");
        }
    }
}

using static NewChallengeApp.EmployeeBase;

namespace NewChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }
        int Age { get; }
        char Sex { get; }
        void AddGrade(float grade);
        void AddGrade(double gradeInDouble);
        void AddGrade(string gradeInString);
        void AddGrade(int gradeInInt);
        void AddGrade(char grade);
        event GradeAddedDelegate GradeAdded;
        Statistics GetStatistics();
    }
}
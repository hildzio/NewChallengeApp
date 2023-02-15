using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        Statistics GetStatistics();
    }
}
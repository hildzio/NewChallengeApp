using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewChallengeApp
{
    public class Supervisor : Person, IEmployee
    {
        private List<float> grades = new();
        public Supervisor(string name, string surname, int age, char sex) : base(name, surname, age, sex)
        {
        }
        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalid grade. Type value between 0 and 100.");
            }
        }
        public void AddGrade(double gradeInDouble)
        {
            var grade = (float)gradeInDouble;
            AddGrade(grade);
        }
        public void AddGrade(string gradeInString)
        {
            if (gradeInString.Length == 1 && char.IsDigit(gradeInString[0]))
            {
                ConvertGrade(gradeInString);
            }
            else if (gradeInString.Length == 2 && ((char.IsDigit(gradeInString[0]) && (gradeInString[1] == '-' || gradeInString[1] == '+')) ||
                                                  (char.IsDigit(gradeInString[1]) && (gradeInString[0] == '-' || gradeInString[0] == '+'))))
            {
                ConvertGrade(gradeInString);
            }
            else
            {
                throw new Exception("String is not float representation.");
            }
        }
        public void ConvertGrade(string grade)
        {
            switch (grade)
            {
                case "6":
                    this.grades.Add(100);
                    break;
                case "6-":
                case "-6":
                    this.grades.Add(95);
                    break;
                case "5+":
                case "+5":
                    this.grades.Add(85);
                    break;
                case "5":
                    this.grades.Add(80);
                    break;
                case "5-":
                case "-5":
                    this.grades.Add(75);
                    break;
                case "4+":
                case "+4":
                    this.grades.Add(65);
                    break;
                case "4":
                    this.grades.Add(60);
                    break;
                case "4-":
                case "-4":
                    this.grades.Add(55);
                    break;
                case "3+":
                case "+3":
                    this.grades.Add(45);
                    break;
                case "3":
                    this.grades.Add(40);
                    break;
                case "3-":
                case "-3":
                    this.grades.Add(35);
                    break;
                case "2+":
                case "+2":
                    this.grades.Add(25);
                    break;
                case "2":
                    this.grades.Add(20);
                    break;
                case "2-":
                case "-2":
                    this.grades.Add(15);
                    break;
                case "1":
                    this.grades.Add(0);
                    break;
                default:
                    throw new Exception("Wrong Grade");
            }
        }
        public void AddGrade(int gradeInInt)
        {
            var grade = (float)gradeInInt;
            this.grades.Add(grade);
        }
        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("Wrong Letter");
            }
        }
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            foreach (var grade in this.grades)
            {
                if (grade < 0)
                {
                    continue;
                }
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
                statistics.GradesList += $", {grade}";
            }
            statistics.Average = statistics.Average / this.grades.Count;

            switch (statistics.Average)
            {
                case var a when a >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var a when a >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var a when a >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var a when a >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;
        }
    }
}
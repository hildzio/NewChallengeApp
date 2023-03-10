using System.Dynamic;

namespace NewChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";
        private string fullFileName;
        private List<float> grades = new();
        public override event GradeAddedDelegate GradeAdded;
        public EmployeeInFile(string name, string surname, int age, char sex)
            : base(name, surname, age, sex)
        {
            fullFileName = $"{name}_{surname}_{fileName}";
        }
        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText($"{fullFileName}"))
                {
                    writer.WriteLine(grade);
                    this.grades.Add(grade);
                    if (GradeAdded != null)
                    {
                        GradeAdded(this, new EventArgs());
                    }
                }
            }
            else
            {
                throw new Exception("Invalid grade. Type value between 0 and 100.");
            }
        }
        public override void AddGrade(double gradeInDouble)
        {
            var grade = (float)gradeInDouble;
            AddGrade(grade);
        }
        public override void AddGrade(string gradeInString)
        {
            if (float.TryParse(gradeInString, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("String is not float.");
            }
        }
        public override void AddGrade(int gradeInInt)
        {
            var grade = (float)gradeInInt;
            AddGrade(grade);
        }
        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong Letter");
            }
        }
        private List<float> ReadGradesFromFile()
        {
            if (File.Exists($"{fullFileName}"))
            {
                using (var reader = File.OpenText($"{fullFileName}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return grades;
        }
        private Statistics CountStatistics(List<float> grades)
        {
            var statistics = new Statistics();
            foreach (var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }
            return statistics;
        }
        public override Statistics GetStatistics()
        {
            var gradesFromFile = this.ReadGradesFromFile();
            var result = this.CountStatistics(gradesFromFile);
            return result;
        }
    }
}
namespace NewChallengeApp
{
    public class Employee
    {
        private List<float> grades = new();
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade. Type value between 0 and 100.");
            }
        }
        public void AddGrade(string gradeInString)
        {
            if (float.TryParse(gradeInString, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float.");
            }
        }
        public void AddGrade(int gradeInInt)
        {
            var grade = (float)gradeInInt;
            this.AddGrade(grade);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average = statistics.Average / this.grades.Count;
            return statistics;
        }
    }
}
namespace NewChallengeApp
{
    public class Employee
    {
        private List<int> grades = new();
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public int Grade { get; private set; }
        public int ResultSum
        {
            get
            {
                return this.grades.Sum();
            }
            set { }
        }
        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public void AddGrade(int grade)
        {
            this.grades.Add(grade);
        }
    }
}
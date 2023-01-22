namespace NewChallengeApp
{
    public class Employee
    {
        private List<int> grades = new();
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }
        public int ResultSum
        {
            get
            {
                return this.grades.Sum();
            }
        }
        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public void Add5Grades(int grade1, int grade2, int grade3, int grade4, int grade5)
        {
            this.grades.Add(grade1);
            this.grades.Add(grade2);
            this.grades.Add(grade3);
            this.grades.Add(grade4);
            this.grades.Add(grade5);

        }
    }
}

namespace NewChallengeApp
{

    public abstract class EmployeeBase : IEmployee
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);
        public abstract event GradeAddedDelegate GradeAdded;
        public EmployeeBase(string name, string surname, int age, char sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Sex = sex;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public char Sex { get; private set; }
        public abstract void AddGrade(float grade);
        public abstract void AddGrade(double gradeInDouble);
        public abstract void AddGrade(string gradeInString);
        public abstract void AddGrade(int gradeInInt);
        public abstract void AddGrade(char grade);
        public abstract Statistics GetStatistics();
    }
}

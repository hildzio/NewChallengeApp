using NewChallengeApp;

string name;
string surname;
int age;

EnterEmployeeData();
Employee employee1 = new(name, surname, age);
AddSeriesOfGrades();
PrintStatistics();

void EnterEmployeeData()
{
    Console.WriteLine("Wtiaj! Jest to aplikacja służąca do oceny pracowników. \n Podaj imię pracownika: ");
    name = Console.ReadLine();
    Console.WriteLine("Teraz podaj nazwisko pracownika: ");
    surname = Console.ReadLine();
    Console.WriteLine("Teraz podaj wiek pracownika: ");
    age = int.Parse(Console.ReadLine());
}
void AddSeriesOfGrades()
{
    employee1.AddGrade(5);
    employee1.AddGrade(1);
    employee1.AddGrade(3);
    employee1.AddGrade(8);
    employee1.AddGrade(9);
}
void PrintStatistics()
{
    Console.WriteLine($"Dla pracownika {name} {surname}, lat {age} są dostępne poniższe dane:");
    var statistics = employee1.GetStatistics();
    Console.WriteLine($"Average: {statistics.Average:N2}");
    Console.WriteLine($"Max: {statistics.Max}");
    Console.WriteLine($"Min: {statistics.Min}");
}
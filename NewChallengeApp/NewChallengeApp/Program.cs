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
    var statistics = employee1.GetStatisticsWithForeach();
    Console.WriteLine($"Dla pętli foreach :\n" +
                      $"Average: {statistics.Average:N2}\n" +
                      $"Max: {statistics.Max}\n" +
                      $"Min: {statistics.Min} \n");

    var statistics1 = employee1.GetStatisticsWithFor();
    Console.WriteLine($"Dla pętli for :\n" +
                      $"Average: {statistics1.Average:N2}\n" +
                      $"Max: {statistics1.Max} \n" +
                      $"Min: {statistics1.Min} \n");

    var statistics2 = employee1.GetStatisticsWithDoWhile();
    Console.WriteLine($"Dla pętli do while :\n" +
                      $"Average: {statistics2.Average:N2} \n" +
                      $"Max: {statistics2.Max} \n" +
                      $"Min: {statistics2.Min} \n");

    var statistics3 = employee1.GetStatisticsWithWhile();
    Console.WriteLine($"Dla pętli do while :\n" +
                      $"Average: {statistics3.Average:N2} \n" +
                      $"Max: {statistics3.Max}\n" +
                      $"Min: {statistics3.Min} \n");
}
using NewChallengeApp;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

var employeeInputName = EnterEmployeeData("name", "Wtiaj! Jest to aplikacja służąca do oceny pracowników. \n Podaj imię pracownika: ");
var employeeInputSurname = EnterEmployeeData("surname", "Podaj nazwisko pracownika: ");
var employeeInputAge = EnterEmployeeAge();
Employee employee = new(employeeInputName, employeeInputSurname, employeeInputAge);
try
{
    AddGradesToEmpoloyee(employee);
}
catch (Exception e)
{
    Console.WriteLine($"Exception catched {e.Message}");
}
finally
{
    PrintStatistics(employee);
}

static string EnterEmployeeData(string input, string message)
{
    bool whileStatus = false;
    input = null;
    while (!whileStatus)
    {
        var inputValue = GetValueFromConsole(message);
        if (!string.IsNullOrEmpty(inputValue))
        {
            input = inputValue;
            whileStatus = true;
        }
        else
        {
            MsgValueCantBeNull();
        }
    }
    return input;
}
static int EnterEmployeeAge()
{
    bool whileStatus = false;
    int age = 0;
    while (!whileStatus)
    {
        var inputAge = GetValueFromConsole("Teraz podaj wiek pracownika: ");
        var succes = int.TryParse(inputAge, out int parsedAge);

        if (succes == true && parsedAge > 0)
        {
            age = parsedAge;
            whileStatus = true;
        }
        else
        {
            MsgValueCantBeNull();
            Console.WriteLine("Wprowadź poprawną wartość wieku w latach.");
        }
    }
    return age;
}
static void MsgValueCantBeNull()
{
    Console.WriteLine("Warotość nie może być NULL.");
}
static string GetValueFromConsole(string inputMessage)
{
    Console.WriteLine(inputMessage);
    var inputFromUser = Console.ReadLine();
    return inputFromUser;
}
void AddGradesToEmpoloyee(Employee employee)
{
    while (true)
    {
        Console.WriteLine($"Podaj kolejną ocenę dla pracowanika {employee.Name} {employee.Surname} lub wciśnij q aby wyjść : ");
        var input = Console.ReadLine();
        if (input == "q")
        {
            break;
        }
        employee.AddGrade(input!);
    }
}
void PrintStatistics(Employee employee)
{
    Console.WriteLine($"Dla pracownika {employeeInputName} {employeeInputSurname}, lat {employeeInputAge} są dostępne poniższe dane:");
    var statistics = employee.GetStatistics();
    Console.WriteLine($"Average: {statistics.Average:N2}\n" +
                      $"Max: {statistics.Max}\n" +
                      $"Min: {statistics.Min} \n" +
                      $"Letter: {statistics.AverageLetter} \n");
}
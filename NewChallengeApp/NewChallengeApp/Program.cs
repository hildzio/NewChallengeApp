using NewChallengeApp;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

var employeeInputName = EnterEmployeeData("name", "Wtiaj! Jest to aplikacja służąca do oceny pracowników. \n\n Podaj imię pracownika: ");
var employeeInputSurname = EnterEmployeeData("surname", "Podaj nazwisko pracownika: ");
var employeeInputAge = EnterEmployeeAge("Teraz podaj wiek pracownika: ");
var employeeInputSex = EnterEmployeeSex("Teraz podaj płeć pracownika (k - kobieta, m - mężczyzna) : ");
var menuInputLetter = FileOrMemoryMenu("Na jakim rodzaju pamięci chcesz operować ? m  - memory (zapis danych do pamięci), f - file (zapis danych do pliku) : ");

if (!string.IsNullOrEmpty(menuInputLetter) && menuInputLetter == "m")
{
    EmployeeInMemory employee = new(employeeInputName, employeeInputSurname, employeeInputAge, employeeInputSex);
    AddGradesToEmpoloyee(employee);
    PrintStatistics(employee);
}
else if (!string.IsNullOrEmpty(menuInputLetter) && menuInputLetter == "f")
{
    EmployeeInFile employee = new(employeeInputName, employeeInputSurname, employeeInputAge, employeeInputSex);
    AddGradesToEmpoloyee(employee);
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
static int EnterEmployeeAge(string message)
{
    bool whileStatus = false;
    int age = 0;
    while (!whileStatus)
    {
        var inputAge = GetValueFromConsole(message);
        var succes = int.TryParse(inputAge, out int parsedAge);

        if (succes == true && parsedAge > 0)
        {
            age = parsedAge;
            whileStatus = true;
        }
        else
        {
            Console.WriteLine("Wprowadź poprawną wartość wieku w latach.");
        }
    }
    return age;
}
static char EnterEmployeeSex(string message)
{
    bool whileStatus = false;
    char sexLetter = '0';
    while (!whileStatus)
    {
        var inputSex = GetValueFromConsole(message);
        var succes = char.TryParse(inputSex, out char parsedSex);

        if (succes == true && parsedSex == 'M' || parsedSex == 'm' || parsedSex == 'K' || parsedSex == 'k')
        {
            sexLetter = char.ToLower(parsedSex);
            whileStatus = true;
        }
        else
        {
            Console.WriteLine("Wprowadź poprawną wartość płci : k lub m");
        }
    }
    return sexLetter;
}
static string FileOrMemoryMenu(string message)
{
    var inputMenu = GetValueFromConsole(message);
    bool whileStatus = false;
    var resultMenu = "";
    while (!whileStatus)
    {
        if (inputMenu == "M" || inputMenu == "m" || inputMenu == "F" || inputMenu == "f")
        {
            resultMenu = inputMenu.ToLower();
            whileStatus = true;
        }
        else
        {
            Console.WriteLine("Wprowadź poprawną wartość menu : f lub m");
        }
    }
    return resultMenu;
}
static string ConvertSexLetterForSexName(char sexLetter)
{
    string sexName = null;
    switch (sexLetter)
    {
        case 'm':
            sexName = "Mężczyzna";
            break;
        case 'k':
            sexName = "Kobieta";
            break;
    }
    return sexName!;
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
void AddGradesToEmpoloyee(IEmployee employee)
{
    while (true)
    {
        Console.WriteLine($"Podaj kolejną ocenę dla pracowanika {employee.Name} {employee.Surname} lub wciśnij q aby wyjść : ");
        var input = Console.ReadLine();
        if (input == "q")
        {
            break;
        }
        try
        {
            if (input == "A" || input == "a" || input == "B" || input == "b" || input == "C" || input == "c" || input == "D" || input == "d" || input == "E" || input == "e")
            {
                var inputChar = char.Parse(input);
                employee.AddGrade(inputChar);
            }
            else
            {
                employee.AddGrade(input!);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception catched {e.Message}");
        }
    }
}
void PrintStatistics(IEmployee employee)
{
    var sexName = ConvertSexLetterForSexName(employeeInputSex);
    Console.WriteLine($"Dla pracownika {employeeInputName} {employeeInputSurname}, lat {employeeInputAge}, płeć {sexName} są dostępne poniższe dane:");
    var statistics = employee.GetStatistics();
    Console.WriteLine($"Grades list: {statistics.GradesList.TrimStart(',')}\n" +
                      $"Average: {statistics.Average:N2}\n" +
                      $"Max: {statistics.Max}\n" +
                      $"Min: {statistics.Min} \n" +
                      $"Letter: {statistics.AverageLetter} \n");
}
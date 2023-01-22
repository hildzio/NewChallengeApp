using NewChallengeApp;
List<int> resultList = new();
string name;
string surname;
int age;
Employee user1 = new("Adam", "Kowalski", 33);
Employee user2 = new("Monika", "Nowak", 23);
Employee user3 = new("Zuzia", "Pawlak", 45);

user1.Add5Grades(5, 1, 3, 8, 9);
user2.Add5Grades(2, 3, 4, 6, 7);
user3.Add5Grades(5, 2, 6, 1, 8);

var result1 = user1.ResultSum;
var result2 = user2.ResultSum;
var result3 = user3.ResultSum;

resultList.Add(result1);
resultList.Add(result2);
resultList.Add(result3);

int maxResult = resultList.Max();

if (maxResult == result1)
{
    name = user1.Name;
    surname = user1.Surname;
    age = user1.Age;
    PrintMsg(name, surname, age, maxResult);
}
else if (maxResult == result2)
{
    name = user2.Name;
    surname = user2.Surname;
    age = user2.Age;
    PrintMsg(name, surname, age, maxResult);
}
else if (maxResult == result3)
{
    name = user3.Name;
    surname = user3.Surname;
    age = user3.Age;
    PrintMsg(name, surname, age, maxResult);
}
static void PrintMsg(string name, string surname, int age, int maxResult)
{
    Console.WriteLine($"Najlepszym wynikiem pracowników jest : {maxResult} \n Osiągnął go : {name} , {surname}, lat {age}");
}
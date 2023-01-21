int[] grades = new int[365];
List<string> daysOfWeeks = new List<string>();
daysOfWeeks.Add("Poniedziałek");
daysOfWeeks.Add("Wtorek");
daysOfWeeks.Add("Środa");
daysOfWeeks.Add("Czwartek");
daysOfWeeks.Add("Piątek");
daysOfWeeks.Add("Sobota");
daysOfWeeks.Add("Niedziela");
Console.WriteLine(daysOfWeeks[0]);

string[] dayOfWeeks2 = { "Poniedziałek", "Wtorek", "Środa", "Czwartek", "Piątek", "Sobota", "Niedziela" };
Console.WriteLine(daysOfWeeks[4]);

for (var i = 0; i < daysOfWeeks.Count; i++)
{
    Console.Write($"{daysOfWeeks[i]}, ");
}
foreach(var day in daysOfWeeks)
{
    Console.WriteLine(day);
}


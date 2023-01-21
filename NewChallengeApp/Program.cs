string name = "Ewa";
char sex = 'F';
int age = 30;

if (sex == 'F' && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (age < 18 && sex == 'M')
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else if (sex == 'M')
{
    Console.WriteLine($"Naszym bohaterem jest mężczyzna {name} w wieku {age} lat.");
}
else
{
    Console.WriteLine($"Naszą bohaterką jest kobieta {name} w wieku {age} lat.");
}
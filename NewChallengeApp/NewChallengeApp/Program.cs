Console.WriteLine("Podaj liczbę do analizy: ");
string digitInString = Console.ReadLine();
char[] digitsFromInput = digitInString.ToArray();
List<string> digitsFromZeroToNine = new();
List<int> occurDigits = new();
int digit = 0;

for (int n = 0; n <= 9; n++)
{
    string nString = digit.ToString();
    digitsFromZeroToNine.Add(nString);
    digit++;
}
Console.WriteLine($"Wyniki dla liczby : {digitInString}");

for (var j = 0; j < digitsFromZeroToNine.Count; j++)
{
    var countOccurDigits = 0;
    for (var i = 0; i < digitsFromInput.Length; i++)
    {
        if (digitsFromInput[i].ToString() == digitsFromZeroToNine[j])
        {
            countOccurDigits++;
        }
    }
    Console.WriteLine($"{digitsFromZeroToNine[j]} => {countOccurDigits}");
}
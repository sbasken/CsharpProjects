string[] values = { "12.3", "45", "ABC", "11", "DEF" };

string strings = "";
decimal decimals = 0.0m;
foreach (var value in values)
{
    decimal parsedValue;
    if (decimal.TryParse(value, out parsedValue))
    {
        decimals += parsedValue;
    } else {
        strings += value;
    }
}

Console.WriteLine($"Message: {strings}");
Console.WriteLine($"Total: {decimals}");


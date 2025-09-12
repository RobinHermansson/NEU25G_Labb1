string verificationInput = "29535123p48723487597645723645";



PrintPredefinedInGreen(verificationInput);
Console.WriteLine("__________________________________________________");

Console.WriteLine($"Total = {CalculateTotalValue(verificationInput)}");

static ulong CalculateTotalValue(string input)
{
    ulong sum = 0;
    for (int i = 0; i < input.Length; i++)
    {
        string fullString = "";
        char currentChar = input[i];
        int indexOfNextOccurrence = GetIndexOfNextOccurrence(input, i, currentChar);
        if (indexOfNextOccurrence != 0) 
        {
            for (int z = 0; z < input.Length; z++)
            {
                if (z <= indexOfNextOccurrence && z >= i)
                {
                    fullString += input[z];
                }
            }
        }
        if (fullString != "")
        {
            ulong value = ulong.Parse(fullString);
            sum += value;
        }
    }
    return sum;
}
static void PrintPredefinedInGreen(string input) 
{ 
    for (int i = 0; i < input.Length; i++)
    {
        char charToFind = input[i];
        int indexOfNextOccurrence = GetIndexOfNextOccurrence(input, i, charToFind);
        if (indexOfNextOccurrence != 0) 
        {
            for (int z = 0; z < input.Length; z++)
            {
                char character = input[z];
                if (z <= indexOfNextOccurrence && z >= i)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(character);
                    Console.ResetColor();
                }
                else
                {
                    Console.Write(character);
                }
            }
            Console.WriteLine();
        }

    }
}
static int GetIndexOfNextOccurrence(string text, int startIndex, char charToFind)
{
    // Interrupts the search for the index if it finds a non-integer in the string.
    for (int i = startIndex; i < text.Length - 1; i++)
    {
        int parsedValue = 0;
        if (!int.TryParse(text[i+1].ToString(), out parsedValue))
        {
            return 0;
        }
        char nextChar = text[i+1];
        if (nextChar == charToFind)
        {
            return i + 1;
        }
    }

    return 0;
}


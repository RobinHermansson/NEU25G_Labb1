while (true)
{
    Console.WriteLine("SELECT ONE OF TWO OPTIONS (1 or 2):\n" +
        "\n1. Use the default string (29535123p48723487597645723645)" +
        "\n2. Write your own string.\n");
    Console.Write("Selection: ");
    string userSelection = Console.ReadLine();

    if (userSelection.Length != 0 ) 
    { 
        switch (userSelection)
        {
            case "1":
                string defaultString = "29535123p48723487597645723645";
                Console.WriteLine("USING DEFAULT STRING");
                Console.WriteLine("=============================================");
                PrintStringAndCalculateTotal(defaultString);
                Console.WriteLine("=============================================");
                Console.WriteLine();
                break;
            case "2":
                Console.WriteLine("Write the string you want to run the check against: ");
                string userInput = Console.ReadLine();
                if (userInput.Length <= 0)
                {
                    PrintWarning("You seem to have not inserted anything... Try again");
                }
                else
                {
                    Console.WriteLine("=============================================");
                    PrintStringAndCalculateTotal(userInput);
                    Console.WriteLine("=============================================");
                    Console.WriteLine();
                }
                break;
            default:
                PrintWarning("That is not a valid selection. Try again.");
                break;
        }
    }
    else
    {
        PrintWarning("That seems like an invalid input. Try again.");
    }
}


static void PrintStringAndCalculateTotal(string input) 
{
    ulong sum = 0;
    for (int i = 0; i < input.Length; i++)
    {
        char charToFind = input[i];
        int indexOfNextOccurrence = GetIndexOfNextOccurrence(text: input, startIndex: i, charToFind: charToFind);
        if (indexOfNextOccurrence == 0)
        {
            continue; // The character does not appear more than once.
        }
        string substringToCheck = input.Substring(i, indexOfNextOccurrence - i);
        if (IsValid(substringToCheck)) 
        {
            for (int z = 0; z < input.Length; z++)
            {
                char character = input[z];
                if (z <= indexOfNextOccurrence && z >= i)
                {
                    PrintInGreen(character);
                }
                else
                {
                    Console.Write(character);
                }
            }
            Console.WriteLine();
            sum = CalculateTotalValue(substringToCheck, sum);
        }
    }
    Console.WriteLine("=============================================");
    Console.WriteLine($"Total: {sum}");
}

// Helper functions
static int GetIndexOfNextOccurrence(string text, int startIndex, char charToFind)
{
    for (int i = startIndex; i < text.Length - 1; i++)
    {
        char nextChar = text[i+1];
        if (nextChar == charToFind)
        {
            return i + 1;
        }
    }

    return 0;
}

static bool IsValid(string input) 
{
    for (int i = 0; i < input.Length; i++)
    {
        if (!int.TryParse(input[i].ToString(), out int numberOutput))
        {
            return false; // Must not contain a non-int.
        } 
    }
    char startChar = input[0]; 
    for (int y = 1; y < input.Length-1; y++)
    {
        if (input[y] == startChar)
        {
            return false; // Char within the string must not be the same as the first/last.
        }
    }
    return true;
}

static ulong CalculateTotalValue(string input, ulong currentSum)
{
    if (input != "")
    {
            ulong value = ulong.Parse(input);
            currentSum += value;
    }
    return currentSum;
}

static void PrintWarning(string text)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(text);
    Console.ResetColor();

}

static void PrintInGreen(char character)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(character);
    Console.ResetColor();

}

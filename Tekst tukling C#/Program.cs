
TekstTukling();
void TekstTukling()
{
    Console.WriteLine("1. Rotate text");
    Console.WriteLine("2. Change word");
    var keyInput = Console.ReadKey();

    Console.Clear();
    Console.WriteLine("Write what you want to change:");
    var textInput = Console.ReadLine();

    if (keyInput.KeyChar == '1')
    {
        Console.WriteLine(RotateText(textInput));
    }
    else if(keyInput.KeyChar == '2')
    {
        ChangeWord(textInput);
    }
    else
    {
        Console.WriteLine("Choose 1 or 2");
    }
}

string RotateText(string input)
{
    char[] stringArray = input.ToCharArray();
    Array.Reverse(stringArray);
    string reversed = new string(stringArray);
    return reversed;
}

void ChangeWord(string input)
{
    input = input.Replace('e', 'a');
    Console.WriteLine($"Your altered text: {input}");
}
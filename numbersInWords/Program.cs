void WriteToConsole (string text)
{
    Console.WriteLine($"{text} = {ParseInt(text)}");
}

WriteToConsole("two hundred forty-six");
WriteToConsole("twenty one thousands two hundred forty-six");
WriteToConsole("twenty one thousands ");
WriteToConsole("seven hundred eighty-three thousand nine hundred and nineteen");



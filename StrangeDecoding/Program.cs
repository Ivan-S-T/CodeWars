int Decode(string s)
{
    string outPut = String.Empty;
    
    foreach (char c in s)
    {
        if (Char.IsDigit(c)) outPut += c.ToString();
    }
    int result = int.Parse(outPut);
    return result % 1024;
}

Decode("1..2...3");

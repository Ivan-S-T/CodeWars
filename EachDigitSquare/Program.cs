int SqrDigits(int n)
{
    int result = 0;
    List<int> squares = new();
    for (int i = n; i > 0; i /= 10)
    {
        int d = i % 10;
        squares.Add(d * d);
    }
   // squares.Reverse();
    int stage = 1;
    for (int i = 0; i < squares.Count; i++)
    {
        result += squares[i] * stage;
        stage *= NextStage(squares[i]);
    }

    return result;

    int NextStage(int n)
    {
        int next = 10;
        if (n > 10)
        {
            next *= 10;
        }
        return next;
    }
}
Console.WriteLine(SqrDigits(123));

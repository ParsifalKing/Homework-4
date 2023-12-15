void PrintNumber(int n)
{
    if( n > 0 )
    {
        Console.Write(n + " ");
        PrintNumber(n-1);
    }
}

PrintNumber(10);
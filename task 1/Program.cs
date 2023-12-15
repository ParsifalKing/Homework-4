void PrintNumber(int n)
{
    if( n > 0 )
    {
        PrintNumber(n-1);
        System.Console.Write(n + " ");
    }
}

PrintNumber(10);

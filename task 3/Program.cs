int  PrintNumber(int n)
{
    if( n == 1 )
    {
      return 1;
    }
    else{
     return n + PrintNumber(n-1);     
    }
    
}

int n = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine(PrintNumber(n));






 
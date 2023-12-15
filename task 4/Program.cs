void SpaceBetween(int n)
{
    if(n > 0)
    {
      SpaceBetween(n/10);
      Console.Write(n%10); 
      Console.Write(" "); 
    }
}

int n = Convert.ToInt32(System.Console.ReadLine());
SpaceBetween(n);

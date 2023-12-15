int cnt=0;

int CountNumber(int n)
{
    if(n > 0)
    {
      CountNumber(n/10);
      cnt++;
    }
    return cnt;
}


int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(CountNumber(n));

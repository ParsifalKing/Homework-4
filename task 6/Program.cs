void FindEvenNumbers(int a, int b)
{  
    if( a < b )
    {
      if(a%2 == 0) Console.Write(a + " "); 
      FindEvenNumbers(a+1 ,b);
    }
}

void FindOddNumbers(int a, int b)
{  
    if( a < b )
    {
      if(a%2 != 0) Console.Write(a + " "); 
      FindOddNumbers(a+1 ,b);
    }
}


int a = Convert.ToInt32(System.Console.ReadLine());
int b = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine("All even numbers from " + a + " to " + b + " are:");
FindEvenNumbers(a,b);
System.Console.WriteLine(" ");


System.Console.WriteLine("All odd numbers from " + a + " to " + b + " are:");
FindOddNumbers(a,b);

using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
  public static void change(int a, int b)
  {
      int buffer = a;
      a = b;
      b = buffer;
      Console.Write ($"a = {a}; b = {b}\n");
      
  }

  public static void Main()
  {
    Random random = new Random();
    int x = 1, y = 2;
    change (x,y);
    Console.WriteLine ($"x = {x}; y = {y}.");
  
  }
}

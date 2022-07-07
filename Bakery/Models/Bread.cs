using System;
using System.Collections.Generic;

namespace Bakery.Models 
{
  public class Bread
  {
    public int Price {get; set;}
    public int Number {get; set;}
    public Bread(int number)
    {
      Number = number;
      Price = PriceCal(Number);
    }
    public static int PriceCal(int number)
    {
      int freeBread = (number / 3);
      int price = ((number - freeBread) * 5);
      return price;
    }
  }
}
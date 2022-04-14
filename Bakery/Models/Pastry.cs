using System;
using System.Collections.Generic;

namespace Bakery.Models 
{
  public class Pastry
  {
    public int Price {get; set;}
    public int Number {get; set;}
    public Pastry(int number)
    {
      Number = number;
      Price = priceCal(Number);
    }
    public static int priceCal(int number)
    {
      int pastriesDiscount = (number / 3);
      int price = ((2 * number) - pastriesDiscount);
      return price;
    }
  }
}
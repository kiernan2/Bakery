using System.Collections.Generic;
using System;
using Bakery.Models;

public class Program
{
  static void Main()
  {
    Console.WriteLine("Welcome to Pierre's bakery");
    Console.WriteLine("Enter how much bread you want price is five dollars a loaf with a buy two get one free deal");
    string breadResponse = Console.ReadLine();
    Bread breadPrice = new Bread(Int32.Parse(breadResponse));
    Console.WriteLine("Enter how many pastries you want Prices two dollars a pastry with a one dollar discount for every third");
    string pastriesResponse = Console.ReadLine();
    new Pastry(Int32.Parse(pastriesResponse));
    Pastry pastryPrice = new Pastry(Int32.Parse(pastriesResponse));
    int total = breadPrice.Price + pastryPrice.Price;
    Console.WriteLine($"Your total cost is {total}$");
  }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace PastryTests
{
  [TestClass]
  public class TestClass
  {
    [TestMethod]
    public void One_Pastry_Price_Check()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(newPastry.Price, 2);
    }
    [TestMethod]
    public void Two_Pastry_Price_Check()
    {
      Pastry newPastry = new Pastry(2);
      Assert.AreEqual(newPastry.Price, 4);
    }
    [TestMethod]
    public void Three_Pastry_Price_Check()
    {
      Pastry newPastry = new Pastry(3);
      Assert.AreEqual(newPastry.Price, 5);
    }
    [TestMethod]
    public void Four_Pastry_Price_Check()
    {
      Pastry newPastry = new Pastry(4);
      Assert.AreEqual(newPastry.Price, 7);
    }
        [TestMethod]
    public void Five_Pastry_Price_Check()
    {
      Pastry newPastry = new Pastry(5);
      Assert.AreEqual(newPastry.Price, 9);
    }
    [TestMethod]
    public void Six_Pastry_Price_Check()
    {
      Pastry newPastry = new Pastry(6);
      Assert.AreEqual(newPastry.Price, 10);
    }
  }
}
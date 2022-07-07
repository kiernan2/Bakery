using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace BreadTests
{
  [TestClass]
  public class TestClass
  {
    [TestMethod]
    public void One_Bread_Price_Check()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(newBread.Price, 5);
    }
    [TestMethod]
    public void Two_Bread_Price_Check()
    {
      Bread newBread = new Bread(2);
      Assert.AreEqual(newBread.Price, 10);
    }
    [TestMethod]
    public void Three_Bread_Price_Check()
    {
      Bread newBread = new Bread(3);
      Assert.AreEqual(newBread.Price, 10);
    }
  }
}
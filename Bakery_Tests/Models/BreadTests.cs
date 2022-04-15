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
    public void one_bread_price_check()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(newBread.Price, 5);
    }
    [TestMethod]
    public void two_bread_price_check()
    {
      Bread newBread = new Bread(2);
      Assert.AreEqual(newBread.Price, 10);
    }
    [TestMethod]
    public void three_bread_price_check()
    {
      Bread newBread = new Bread(3);
      Assert.AreEqual(newBread.Price, 10);
    }
  }
}
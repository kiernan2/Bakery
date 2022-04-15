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
    public void one_pastry_price_check()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(newPastry.Price, 2);
    }
    [TestMethod]
    public void two_pastry_price_check()
    {
      Pastry newPastry = new Pastry(2);
      Assert.AreEqual(newPastry.Price, 4);
    }
    [TestMethod]
    public void three_pastry_price_check()
    {
      Pastry newPastry = new Pastry(3);
      Assert.AreEqual(newPastry.Price, 5);
    }
    [TestMethod]
    public void four_pastry_price_check()
    {
      Pastry newPastry = new Pastry(4);
      Assert.AreEqual(newPastry.Price, 7);
    }
        [TestMethod]
    public void five_pastry_price_check()
    {
      Pastry newPastry = new Pastry(5);
      Assert.AreEqual(newPastry.Price, 9);
    }
    [TestMethod]
    public void six_pastry_price_check()
    {
      Pastry newPastry = new Pastry(6);
      Assert.AreEqual(newPastry.Price, 10);
    }
  }
}
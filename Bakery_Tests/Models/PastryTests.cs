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
    public void three_pastry_price_check()
    {
      Pastry newPastry = new Pastry(3);
      Assert.AreEqual(newPastry.Price, 5);
    }
  }
}
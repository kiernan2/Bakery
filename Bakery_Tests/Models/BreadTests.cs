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
    public void three_bread_price_check()
    {
      Bread newBread = new Bread(3);
      Assert.AreEqual(newBread.Price, 10);
    }
  }
}
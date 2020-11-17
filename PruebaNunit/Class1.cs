using NUnit.Framework;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades;

namespace PruebaNunit
{
  [TestFixture]
  public class Class1
  {
    // public Color color;

    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void NUnitIsBlueAprimaryColorTest()
    {
      //Arrange
      String color = "Blue";

      //Act
      bool actual = color.IsPrimaryColor();

      //Arrange
      const bool expected = true;
      // Assert.Fail();
      Assert.AreEqual(expected, actual);

    }
    [Test]
    public void NUnitIsOrangeAprimaryColorTest()
    {
      //Arrange
      String color = "Orange";

      //Act
      bool actual = color.IsPrimaryColor();

      //Arrange
      const bool expected = true;
      // Assert.Fail();
      Assert.AreEqual(expected, actual, "NOT EQUALS!!!!");

    }
  }
}

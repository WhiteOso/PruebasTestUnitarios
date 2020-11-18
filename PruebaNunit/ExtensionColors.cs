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
  [Author("JCALERO")]
  [Category("ALL")]
  public class ExtensionColors
  {
    // public Color color;

    [SetUp]
    public void Setup()
    {

    }

    [TestCase(Author = "JCalero")]
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
    [TestCase]
    [Author("JCALERO")]

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

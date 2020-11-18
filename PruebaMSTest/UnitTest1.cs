using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utilidades;

namespace PruebaMSTest
{
  [TestClass]
  [TestCategory("ALL")]
  public class UnitTest1
  {
    [TestMethod]
    public void MStIsBlueAprimaryColorTest()
    {
      {
        //Arrange
        String color = "Blue";

        //Act
        bool actual = color.IsPrimaryColor();

        //Arrange
        const bool expected = true;
        Assert.AreEqual(expected, actual);

      }
    }
    [TestMethod]
    public void MStIsOrangeAprimaryColorTest()
    {
      {
        //Arrange
        String color = "Orange";

        //Act
        bool actual = color.IsPrimaryColor();

        //Arrange
        const bool expected = true;
        Assert.AreEqual(expected, actual);

      }
    }
  }
}

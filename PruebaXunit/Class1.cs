using System;
using System.Drawing;
using Xunit;
using Utilidades;

namespace PruebaXunit
{
  public class Class1
  {

    public Color color;

    [Fact]
    public void XunitIsBlueAprimaryColorTest()
    {
      //Arrange
      String color = "Blue";

      //Act
      bool actual = color.IsPrimaryColor();

      //Arrange
      const bool expected = true;
      Assert.Equal(expected, actual);

    }

    [Fact]
    public void XunitIsOrangeAprimaryColorTest()
    {
      //Arrange
      String color = "Orange";

      //Act
      bool actual = color.IsPrimaryColor();

      //Arrange
      const bool expected = true;
      Assert.Equal(expected, actual);

    }
  }
}

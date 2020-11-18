using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades;

namespace PruebaNunit
{
  [TestFixture]
  [Category("ALL")]
  public class EmployeeTests
  {
    [TestCase(Author = "JCalero")]
    public void When_AgeGreaterAndEqualTo60_Expects_IsSeniorCitizeAsTrue()
    {
      Employee emp = new Employee();
      emp.Age = 60;

      bool result = emp.IsSeniorCitizen();

      Assert.That(result == true);
    }

    [TestCase(60, Author = "JCalero")]
    [TestCase(80, Author = "JCalero")]
    [TestCase(90, Author = "JCalero")]
    public void When_AgeGreaterAndEqualTo60_Expects_IsSeniorCitizeAsTrue(int age)
    {
      Employee emp = new Employee();
      emp.Age = age;

      bool result = emp.IsSeniorCitizen();

      Assert.That(result == true);
    }

    [TestCase(29, ExpectedResult = false, Author = "JCalero")]
    [TestCase(0, ExpectedResult = false, Author = "JCalero")]
    [TestCase(60, ExpectedResult = true, Author = "JCalero")]
    [TestCase(80, ExpectedResult = true, Author = "JCalero")]
    [TestCase(90, ExpectedResult = true, Author = "JCalero")]
    public bool When_AgeGreaterAndEqualTo60_Expects_IsSeniorCitizeAsTrueExpected(int age)
    {
      Employee emp = new Employee();
      emp.Age = age;

      bool result = emp.IsSeniorCitizen();

      return result;
    }
  }
}

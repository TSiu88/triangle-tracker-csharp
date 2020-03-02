using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker.Models;

namespace TriangleTracker.TestTools
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void DetermineIfTriangle_EquilateralTriangle_True()
    {
      Triangle testTriangle = new Triangle(3,3,3);
      Assert.AreEqual(true, testTriangle.DetermineIfTriangle());
    }

    [TestMethod]
    public void DetermineIfTriangle_NotATriangle_False()
    {
      Triangle testTriangle = new Triangle(5,10,2);
      Assert.AreEqual(false, testTriangle.DetermineIfTriangle());
    }
  }
}
/*
 * PROG 2070
 * By: Justin Harvey
 * Assignment 1
 * CircleTest.cs
 * Professor: Rob Bowyer
 */
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070Assign1.Tests
{
    [TestFixture]
    public class CircleTest
    {
        Circle circ = new Circle();

        [Test]
        public void GetRadiusReturnsCorrect()
        {
            //Arrange
            circ.Radius = 1;
            //Act
            double result = circ.GetRadius();
            //Assert
            Assert.AreEqual(result,circ.Radius);
        }
        [Test]
        public void SetRadiusTest_ChangesRadius()
        {
            //Arrange
            circ.Radius = 1;
            int value = circ.Radius + 1;
            //Act
            circ.SetRadius(value);
            //Assert
            Assert.AreEqual(circ.Radius,value);
        }
        [Test]
        public void GetCircumfrenceTest()
        {
            //Arrange
            circ.Radius = 5;
            //Act
            var result = Math.Round(circ.GetCircumfrence(),2);
            double circumfrenceOfFive = 31.42;
            //Assert
            Assert.AreEqual(circumfrenceOfFive, result);
        }
        [Test]
        public void GetAreaTest()
        {
            //Arrange
            circ.Radius = 5;
            //Act
            var result = Math.Round(circ.GetArea(), 2);
            double areaOfFive = 78.54;
            //Assert
            Assert.AreEqual(areaOfFive, result);
        }
    }
}

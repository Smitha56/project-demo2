using System;
using NUnit.Framework;
using CalcLibrary;

namespace CalcLibraryTests
{
    [TestFixture]
    public class ArithopsTests
    {
        [Test]
        public void Add_AcceptingTwoDoubleValues_ReturnsSum() //Test Case1
        {
            //Arrange
            double ExpectedResult = 10.6f;
            //Act
            IArithops arithOps = new Arithops();
            double ActualResult = arithOps.Add(5.3f, 5.3f);
            //Assert
            Assert.AreEqual(ExpectedResult, ActualResult);
        }

        [Test]
        public void Sub_AcceptingTwoDoubleValues_ReturnsDiff() //Test Case2
        {
            //Arrange
            double ExpectedResult = 3.0f;
            //Act
            IArithops arithOps = new Arithops();
            double ActualResult = arithOps.Sub(8.0f, 5.0f);
            //Assert
            Assert.AreEqual(ExpectedResult, ActualResult);
        }
        [Test]
        public void Mul_AcceptingTwoDoubleValues_ReturnsProduct()  //Test Case3
        {
            //Arrange
            double ExpectedResult = 25.0f;
            //Act
            IArithops arithOps = new Arithops();
            double ActualResult = arithOps.Mul(5.0f, 5.0f);
            //Assert
            Assert.AreEqual(ExpectedResult, ActualResult);
        }
        [Test]
        public void Div_AcceptingTwoDoubleValues_ReturnsQua()  //Test Case4
        {
            //Arrange
            double ExpectedResult = 5.3f;
            //Act
            IArithops arithOps = new Arithops();
            double ActualResult = arithOps.Div(10.6f, 2.0f);
            //Assert
            Assert.AreEqual(ExpectedResult, ActualResult);
        }
        [TestCase(3.0, 2.0, 5.0)]
        [TestCase(5.0, 5.0, 10.0)]
        public void Add_Get2Values_ReturnsSum(double n1, double n2, double result)
        {
            IArithops arithops = new Arithops();
            //Act
            double actualResult = arithops.Add(n1, n2);
            //Assert
            Assert.That(actualResult, Is.EqualTo(result));
        }

        [TestCase(3.0f, 2.0f, 9.0f)]
        [TestCase(5.0f, 2.0f, 25.0f)]
        public void Power_Get2Values_ReturnsXpowY(double n1, double n2, double result)
        {
            IArithops arithops = new Arithops();
            //Act
            double actualResult = arithops.Pow(n1, n2,result);
            //Assert
            Assert.That(actualResult, Is.EqualTo(result));
        }
        [Test]
        public void Netsalary() 
        {
            //Arrange
            double ExpectedResult = 37200;
            //Act
            IArithops arithOps = new Arithops();
            double ActualResult = arithOps.netsalary(5000,4000,25000,3200);
            //Assert
            Assert.AreEqual(ExpectedResult, ActualResult);
        }
    }
}
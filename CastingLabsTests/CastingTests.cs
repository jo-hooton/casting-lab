using Microsoft.VisualStudio.TestTools.UnitTesting;
using CastingLabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingLabs.Tests
{
    [TestClass()]
    public class CastingTests
    {
        [TestMethod()]
        public void CastFromDoubleToIntTest()
        {
            // arrange
            var testInstance = new Casting();
            int expectedOutput = 12;

            // act
            int actualOutput = testInstance.CastFromDoubleToInt(12.75);

            // assert
            Assert.AreEqual(expectedOutput, actualOutput);

        }

        [TestMethod()]
        public void Box_And_Unbox_A_DateTimeObject()
        {
            // arrange
            var testInstance = new Casting();
            var d = new DateTime(2001, 01, 01, 00, 01, 00);
            string expectedOutput = "01/01/2001 00:01:00";

            // act
            string actualOutput = testInstance.BoxThenUnbox(d);

            // assert

            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
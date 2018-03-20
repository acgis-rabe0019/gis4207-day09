using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoordConvertersBLL;


namespace CoordConvertersBLLTests
{
    [TestClass]
    public class DMSConverterTest
    {
        [TestMethod]
        public void DMS2Dd_InvalidNcoord_Returns9999()
        {
            //Arrange
            DMSConverter target = new DMSConverter();
            double expected = 9999;

            DMSCoord testCoord = new DMSCoord();
            testCoord.deg = 71;
            testCoord.min = 61;
            testCoord.sec = 200;
            testCoord.quadrant = Quadrant.N;

            //Act
            double actual = target.Dms2Dd(testCoord);
            
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DMS2Dd_ValidNcoord_Calculated()
        {
            //Arrange
            DMSConverter target = new DMSConverter();
            double expected = 45.425533;

            DMSCoord testCoord = new DMSCoord();
            testCoord.deg = 45;
            testCoord.min = 25;
            testCoord.sec = 31.9188;
            testCoord.quadrant = Quadrant.N;

            //Act
            double actual = target.Dms2Dd(testCoord);

            //Assert
            Assert.AreEqual(expected, actual,0);
        }

    }
}

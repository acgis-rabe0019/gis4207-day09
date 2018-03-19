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
            double expected = 45.425533;

            DMSCoord testCoord = new DMSCoord();
            testCoord.deg = 45;
            testCoord.min = 25;
            testCoord.sec = 31.9188;
            testCoord.quandrant = Quandrant.N;

            //Act
            double actual = target.Dms2Dd(testCoord);
            
            //Assert
            Assert.AreEqual(expected, actual);
        }
        
    }
}

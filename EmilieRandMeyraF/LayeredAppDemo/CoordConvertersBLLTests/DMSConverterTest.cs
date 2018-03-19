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
            double dd = 0;
            double expected = dd;

            //Act
            string actual = target.dmsCoord();
            

            //Assert
            Assert.AreEqual(expected, actual);
        }
        
    }
}

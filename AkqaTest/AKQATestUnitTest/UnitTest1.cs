using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AkqaTest;
using System.Web;

namespace AKQATestUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AmountInWords()
        {
            // Arrange
            string name = "AKQA TEST";
            string amount = "1452.23";
            string amountinwords = "Name - AKQA TEST | Amount - 1452.23  | Amount in words - One Thousand Four Hundred  Fifty-Two dollars Twenty-Three cents";
            int wordcount = amountinwords.Length;
            int testresultCount;
            
            //Act
            AKQA obj=new AKQA();
            var result = obj.GetPersonData(name, amount);
            testresultCount = result.Length;

            //Assert
            Assert.AreEqual(wordcount, testresultCount);
        }
    }
}

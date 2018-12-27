using System;
using check_funcs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using USER;


namespace UnitTest
{
    [TestClass]
    public class ScheduLuz_tests
    {
        [TestMethod]//what the test going to check? _ who is able to rich it? _ what it returns?
        public void CanInsertWrongValues_CheckOnlyNums_ReturnsFalse()
        {
            //Arrange
            var checker = new CheckDetails();

            // Act
            var result = checker.Check_onlyNums("5555aaa");

            // Assert
            Assert.IsFalse(result);
            
        }

        [TestMethod]
        public void Checking_EmailAdress_ReturnTrue()
        {
            //Arrange
            var checker = new CheckDetails();

            //Act
            var result = checker.CheckEmail("tom123@gmail.com");

            //Assert
            Assert.IsTrue(result);

        }

       [TestMethod]
        public void Checking_Event_Creation_ReturnTrue()
        {
            //Arrange
            var checker = new DBfuncs();
            DateTime date = new DateTime(2018, 10, 12);

            //Act
            var result = checker.insertToEvents("1", "testFunctioninsert", "test details", "test place", "test privacy", "test up for cancellation"
                                                     , date, "test hours start", "test hours end", "test minute starts", "test minutes ends", "test regular");

            //Assert
            Assert.IsFalse(result);
        }
    }
}//public bool insertToEvents(string userID, string title, string details, string place, string privacy, string up_for_cancellation
 //, DateTime date, string hours_start, string hours_end, string minutes_start, string minutes_end, string kind = "Regular")

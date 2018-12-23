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

        public void LogoutManagerWorks_AsManager_ReturnsTrue()
        {
            //Arrange

        }
    }
}

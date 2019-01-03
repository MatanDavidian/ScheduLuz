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

        [TestMethod]
        public void Check_User_get_ParenEmail()
        {
            //Arrange
            var checker = new User();
            string expectedArray =  "aviran@gmail.com" ;

            //Act
            string result = checker.getParentEmail();

            //String Assert
            StringAssert.Equals(expectedArray, result);
        }

        [TestMethod]
        public void Check_User_get_Class_Number()
        {
            //Arrange
            var checker = new User();
            string expectedArray = "1";

            //Act
            string result = checker.getClassNumber();

            //String Assert
            StringAssert.Equals(expectedArray, result);
        }

        [TestMethod]
        public void Check_User_get_FreeTxt()
        {
            //Arrange
            var checker = new User();
            string expectedArray = "Some free Txt should be here.";

            //Act
            string result = checker.getFreeTxt();

            //String Assert
            StringAssert.Equals(expectedArray, result);
        }

        [TestMethod]
        public void Check_User_get_Hobies()
        {
            //Arrange
            var checker = new User();
            string expectedArray = "Sport, Runing, Music";

            //Act
            string result = checker.getHobies();

            //String Assert
            StringAssert.Equals(expectedArray, result);
        }

        [TestMethod]
        public void Check_User_get_Grade()
        {
            //Arrange
            var checker = new User();
            string expectedArray = "A";

            //Act
            string result = checker.getGrade();

            //String Assert
            StringAssert.Equals(expectedArray, result);
        }

        [TestMethod]
        public void Check_User_get_BirthDate()
        {
            //Arrange
            var checker = new User();
            string expectedArray = "10, 10, 2018";

            //Act
            string result = checker.getBirthDate();

            //String Assert
            StringAssert.Equals(expectedArray, result);
        }

        [TestMethod]
        public void Check_User_get_Email()
        {
            //Arrange
            var checker = new User();
            string expectedArray = "Aviran123@gmail.com";

            //Act
            string result = checker.getEmail();

            //String Assert
            StringAssert.Equals(expectedArray, result);
        }

        [TestMethod]
        public void Check_User_get_Address()
        {
            //Arrange
            var checker = new User();
            string expectedArray = "Since 12";

            //Act
            string result = checker.getAddress();

            //String Assert
            StringAssert.Equals(expectedArray, result);
        }

        [TestMethod]
        public void Check_User_get_PhoneNumber()
        {
            //Arrange
            var checker = new User();
            string expectedArray = "0501234567";

            //Act
            string result = checker.getPhoneNumber();

            //String Assert
            StringAssert.Equals(expectedArray, result);
        }

        [TestMethod]
        public void Check_User_get_getUsername()
        {
            //Arrange
            var checker = new User();
            string expectedArray = "Avirangur";

            //Act
            string result = checker.getUsername();

            //String Assert
            StringAssert.Equals(expectedArray, result);
        }

        [TestMethod]
        public void Check_User_get_Password()
        {
            //Arrange
            var checker = new User();
            string expectedArray = "1234";

            //Act
            string result = checker.getPassword();

            //String Assert
            StringAssert.Equals(expectedArray, result);
        }

        [TestMethod]
        public void Check_User_get_Permission()
        {
            //Arrange
            var checker = new User();
            string expectedArray = "Manager";

            //Act
            string result = checker.getPermission();

            //String Assert
            StringAssert.Equals(expectedArray, result);
        }

        [TestMethod]
        public void Check_User_get_ID()
        {
            //Arrange
            var checker = new User();
            string expectedArray = "123111234";

            //Act
            string result = checker.getID();

            //String Assert
            StringAssert.Equals(expectedArray, result);
        }

        [TestMethod]
        public void Check_User_get_Name()
        {
            //Arrange
            var checker = new User();
            string expectedArray = "Aviran Gur";

            //Act
            string result = checker.getName();

            //String Assert
            StringAssert.Equals(expectedArray, result);
        }

        [TestMethod]
        public void Check_User_get_LastName()
        {
            //Arrange
            var checker = new User();
            string expectedArray = "Gur";

            //Act
            string result = checker.getLastName();

            //String Assert
            StringAssert.Equals(expectedArray, result);
        }
    }
}

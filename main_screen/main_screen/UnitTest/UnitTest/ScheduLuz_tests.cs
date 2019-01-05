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
            checker = checker.GetUser("1");
            string expectedArray = "pstudent1@gmail.com";

            //Act
            string result = checker.getParentEmail();

            //String Assert
            Assert.AreEqual(expectedArray, result);
        }

        [TestMethod]
        public void Check_User_get_Class_Number()
        {
            //Arrange
            var checker = new User();
            checker = checker.GetUser("1");
            string expectedArray = "3";

            //Act
            string result = checker.getClassNumber();

            //String Assert
            Assert.AreEqual(expectedArray, result);
        }

        [TestMethod]
        public void Check_User_get_FreeTxt()
        {
            //Arrange
            var checker = new User();
            checker = checker.GetUser("123456789");
            string expectedArray = "aviran free text";

            //Act
            string result = checker.getFreeTxt();

            //String Assert
            Assert.AreEqual(expectedArray, result);
        }

        [TestMethod]
        public void Check_User_get_Hobies()
        {
            //Arrange
            var checker = new User();
            checker = checker.GetUser("123456789");
            string expectedArray = "aviran hobies";

            //Act
            string result = checker.getHobies();

            //String Assert
            Assert.AreEqual(expectedArray, result);
        }

        [TestMethod]
        public void Check_User_get_Grade()
        {
            //Arrange
            var checker = new User();
            checker = checker.GetUser("1");
            string expectedArray = "11";

            //Act
            string result = checker.getGrade();

            //String Assert
            Assert.AreEqual(expectedArray, result);
        }

        [TestMethod]
        public void Check_User_get_BirthDate()
        {
            //Arrange
            var checker = new User();
            checker = checker.GetUser("123456789");
            string expectedArray = "1/12/1992 12:00:00 AM";

            //Act
            string result = checker.getBirthDate();

            //String Assert
            Assert.AreEqual(expectedArray, result);
        }

        [TestMethod]
        public void Check_User_get_Email()
        {
            //Arrange
            var checker = new User();
            checker = checker.GetUser("123456789");
            string expectedArray = "aviran@gmail.com";

            //Act
            string result = checker.getEmail();

            //String Assert
            Assert.AreEqual(expectedArray, result);
        }

        [TestMethod]
        public void Check_User_get_Address()
        {
            //Arrange
            var checker = new User();
            checker = checker.GetUser("123456789");
            string expectedArray = "avirans house 1";

            //Act
            string result = checker.getAddress();

            //String Assert
            Assert.AreEqual(expectedArray, result);
        }

        [TestMethod]
        public void Check_User_get_PhoneNumber()
        {
            //Arrange
            var checker = new User();
            checker = checker.GetUser("123456789");
            string expectedArray = "0544444444";

            //Act
            string result = checker.getPhoneNumber();

            //String Assert
            Assert.AreEqual(expectedArray, result);
        }

        [TestMethod]
        public void Check_User_get_getUsername()
        {
            //Arrange
            var checker = new User();
            checker = checker.GetUser("123456789");
            string expectedArray = "avirangur";

            //Act
            string result = checker.getUsername();

            //String Assert
            Assert.AreEqual(expectedArray, result);
        }

        [TestMethod]
        public void Check_User_get_Password()
        {
            //Arrange
            var checker = new User();
            checker = checker.GetUser("123456789");
            string expectedArray = "1";

            //Act
            string result = checker.getPassword();

            //String Assert
            Assert.AreEqual(expectedArray, result);
        }

        [TestMethod]
        public void Check_User_get_Permission()
        {
            //Arrange
            var checker = new User();
            checker = checker.GetUser("123456789");
            string expectedArray = "teacher";

            //Act
            string result = checker.getPermission();

            //String Assert
            Assert.AreEqual(expectedArray, result);
        }

        [TestMethod]
        public void Check_User_get_ID()
        {
            //Arrange
            var checker = new User();
            checker = checker.GetUser("123456789");
            string expectedArray = "123456789";

            //Act
            string result = checker.getID();

            //String Assert
            Assert.AreEqual(expectedArray, result);
        }

        [TestMethod]
        public void Check_User_get_Name()
        {
            //Arrange
            var checker = new User();
            checker = checker.GetUser("123456789");
            string expectedArray = "aviran";

            //Act
            string result = checker.getName();

            //String Assert
            Assert.AreEqual(expectedArray, result);
        }

        [TestMethod]
        public void Check_User_get_LastName()
        {
            //Arrange
            var checker = new User();
            checker = checker.GetUser("123456789");
            string expectedArray = "gur";

            //Act
            string result = checker.getLastName();

            //String Assert
            Assert.AreEqual(expectedArray, result);
        }

        [TestMethod]
        public void Check_GetEventTitle_returns_event()
        {
            //Arrange
            var checker = new Event.Event();
            checker = checker.getEvent("51", false);
            string expectedArray = "Toms event";

            //Act
            string result = checker.getTitle();


            //String Assert
            Assert.AreEqual(expectedArray, result);
        }

        [TestMethod]
        public void Check_GetEventDetails_returns_event()
        {
            //Arrange
            var checker = new Event.Event();
            checker = checker.getEvent("51", false);
            string expectedArray = "123123123";

            //Act
            string result = checker.getDetails();


            //String Assert
            Assert.AreEqual(expectedArray, result);
        }

        [TestMethod]
        public void Check_GetEventPlace_returns_event()
        {
            //Arrange
            var checker = new Event.Event();
            checker = checker.getEvent("51", false);
            string expectedArray = "here";

            //Act
            string result = checker.getPlace();


            //String Assert
            Assert.AreEqual(expectedArray, result);
        }

        [TestMethod]
        public void Check_GetEventDate_returns_event()
        {
            //Arrange
            var checker = new Event.Event();
            checker = checker.getEvent("51", false);
            string expectedArray = "12/10/2018";

            //Act
            string resultDay = checker.getTheDate().Day.ToString();
            string resultMonth = checker.getTheDate().Month.ToString();
            string resultYear= checker.getTheDate().Year.ToString();
            string result = resultMonth + "/" + resultDay + "/" + resultYear;


            //String Assert
            Assert.AreEqual(expectedArray, result);
        }
    }
}

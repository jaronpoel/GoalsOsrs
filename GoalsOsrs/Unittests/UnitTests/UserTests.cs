using System;
using System.Collections.Generic;
using System.Linq;
using Exceptions.User;
using Interfaces.DTO;
using Logic;
using Logic.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unittests.TestDal;

namespace Unittests
{
    [TestClass]
    public class UserTests
    {
        #region Positive

        [TestMethod]
        public void SignUp()
        {
            //Arrange
            var testDal = new UserTestDal();
            UserCollection userCollection = new UserCollection(testDal);

            ////Act
            IUser user = userCollection.SignUp("Jaron", "123456", "jaron.poel@gmail.com");

            //Assert
            Assert.AreEqual(testDal.users.Count(), 3);
            Assert.AreEqual(user.Name, "Jaron");
            Assert.AreEqual(user.Password, "123456");
            Assert.AreEqual(user.Email, "jaron.poel@gmail.com");
        }

        [TestMethod]
        public void SignUpAndIn()
        {
            //Arrange
            IUser user;
            var testDal = new UserTestDal();
            UserCollection userCollection = new UserCollection(testDal);

            //Act
            userCollection.SignUp("Jaron2", "123456", "jaron@gmail.com");

            user = userCollection.SignIn("jaron@gmail.com", "123456");

            Assert.AreEqual(user.Name, "Jaron2");
            Assert.AreEqual(user.Id, 3);
        }

        [TestMethod]
        public void GetByID()
        {
            //Arrange
            IUser user;
            var testDal = new UserTestDal();
            UserCollection userCollection = new UserCollection(testDal);
            int id = 1;
            //Act

            user = userCollection.GetUserByID(id);

            //Assert
            Assert.AreEqual(user.Name, "Jaron");
            Assert.AreEqual(user.Id, 1);
        }

        [TestMethod]
        public void Delete()
        {
            //Arrange
            IUser user;
            var testDal = new UserTestDal();
            UserCollection userCollection = new UserCollection(testDal);
            int id = 1;
            //Act

            bool delete = userCollection.DeleteUser(id);

            //Assert
            Assert.IsTrue(delete);
        }

        #endregion

        #region Negative

        [TestMethod]
        public void SignUpFailedOnName()
        {
            //Arrange
            IUser user;
            var testDal = new UserTestDal();
            UserCollection userCollection = new UserCollection(testDal);

            //Act
            user = userCollection.SignUp(null, "123456", "jaron.poel@gmail.com");

            //Assert
            Assert.AreEqual(user, null);
        }

        [TestMethod]
        public void SignUpFailedOnPassword()
        {
            //Arrange
            IUser user;
            var testDal = new UserTestDal();
            UserCollection userCollection = new UserCollection(testDal);

            //Act
            user = userCollection.SignUp("Jaron", null, "jaron.poel@gmail.com");

            //Assert
            Assert.AreEqual(user, null);
        }

        [TestMethod]
        public void SignUpFailedOnEmail()
        {
            //Arrange
            IUser user;
            var testDal = new UserTestDal();
            UserCollection userCollection = new UserCollection(testDal);

            //Act
            user = userCollection.SignUp("Jaron", "123456", null);

            //Assert
            Assert.AreEqual(user, null);
        }

        [TestMethod]
        public void SignUpAndInFailed()
        {
            //Arrange
            IUser user;
            var testDal = new UserTestDal();
            UserCollection userCollection = new UserCollection(testDal);

            //Act
            userCollection.SignUp("Jaron2", "123456", "jaron@gmail.com");

            user = userCollection.SignIn("jaron@gmail.com", "12345654321");

            //Assert
            Assert.AreEqual(user, null);
        }

        [TestMethod]
        public void GetByIDFailed()
        {
            //Arrange
            IUser user;
            var testDal = new UserTestDal();
            UserCollection userCollection = new UserCollection(testDal);
            int id = 7;
            //Act

            user = userCollection.GetUserByID(id);

            //Assert
            Assert.AreEqual(user, null);
        }

        [TestMethod]
        public void DeleteFailed()
        {
            //Arrange
            IUser user;
            var testDal = new UserTestDal();
            UserCollection userCollection = new UserCollection(testDal);
            int id = 7;
            //Act

            bool delete = userCollection.DeleteUser(id);

            //Assert
            Assert.IsFalse(delete);
        }
        #endregion

    }
}

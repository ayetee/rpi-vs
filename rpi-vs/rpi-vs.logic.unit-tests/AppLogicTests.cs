using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using rpi_vs.models;

namespace rpi_vs.logic.unit_tests
{
    [TestClass]
    public class AppLogicTests
    {
        private App _app;
        private User _user;
        private AppLogic _appLogic;
        private static string _username = "username";
        private static string _password = "12321";

        [TestInitialize]
        public void TestInitialise()
        {
            _user = new User() { Username = _username, Password = _password };
            _app = new App();
            _app.Users.Add(_user);
            _appLogic = new AppLogic(_app);
        }

        [TestMethod]
        public void Login_ValidUser_Success()
        {
            var user = _appLogic.Login(_username, _password);
            Assert.IsNotNull(user);
        }
    }
}

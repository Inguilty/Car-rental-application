using AspNetIdentity.Logic.Core.Extensions;
using AspNetIdentity.Logic.Core.Utils;
using AspNetIdentity.Logic.Shared.Interfaces;
using Autofac;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspNetIdentity.Tests.Logic.Core
{
    /// <summary>
    /// Contains unit tests for the tyoe <see cref="UserExtensions"/>
    /// </summary>
    [TestClass]
    public class UserExtensionTests
    {
        #region methods

        [ClassInitialize]
        public static void ClassInitialize(TestContext textContext)
        {
            StartupUtil.InitLogic(true);
        }

        [TestMethod]
        public void ToTransportModelTest()
        {
            //arrange
            var instance = StartupUtil.Container.Resolve<IUserRepository>();
            var userId = 1;
            //act
            var testData = instance.GetUserByIdAsync(userId).Result;
            //assert
            Assert.IsNotNull(testData);
            Assert.AreEqual(userId,testData.Id);
        }

        #endregion
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using System.Web.Routing;
using WebApplication2.Controllers;

namespace FaceRecognition.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async void Login_Website()
        {
            var helper = new MockHelper();
            var context = helper.MakeFakeContext();

            //var test = new Mock<TestLesson>();

            var controller = new AccountController();
            var Username = "phamminhhuyen";
            var password = "croprokiwi";
            controller.ControllerContext = new ControllerContext(context.Object, new RouteData(), controller);

            //var redirectRoute = controller.Login(Username, password) as Task<ActionResult>;

            var redi = await controller.Login(Username, password) as RedirectToRouteResult;
            //
            Assert.IsNotNull(redi);
            Assert.AreEqual("Index", redi.RouteValues["action"]);
            Assert.AreEqual("Home", redi.RouteValues["controller"]);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GetOrganized.Controllers;
using System.Web.Mvc;

namespace GetOrganized.Tests.Controllers
{
    [TestClass]
    public class TodoTest
    {
        [TestMethod]
        public void Should_Display_A_List_Of_Todo_Items()
        {
            TodoController controller = new TodoController();

            var viewResult = controller.Index() as ViewResult;
            Assert.AreEqual(GetOrganized.Models.Todo.ThingsToBeDone, viewResult.ViewData.Model);
        }

        [TestMethod]
        public void Should_Load_Create_View()
        {
            var viewResult = new TodoController().Create() as ViewResult;

            Assert.AreEqual(String.Empty, viewResult.ViewName);
        }
    }
}

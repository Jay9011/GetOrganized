using GetOrganized.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using System.Web.Mvc;

namespace GetOrganized.Tests.Controllers
{
    [TestClass]
    public class TopicControllerTest
    {
        [TestMethod]
        public void Should_Have_List_Of_Topics_With_And_Color()
        {
            
        }

        [TestMethod]
        public void Should_Convert_Color_To_Hex_Value()
        {
            var aShadeOfRedTopic = new Topic { Color = Color.FromArgb(0, 208, 0, 0) };
            Assert.AreEqual("#D00000", aShadeOfRedTopic.ColorInWebHex());
        }

        [TestMethod]
        public void Should_Create_Topic_And_Notify_The_User()
        {
            var professionalDevelopment = new Topic { Id = 3, Color = ColorTranslator.FromHtml("#000000"), Name = "Professional Development" };

            var formValue = new FormCollection();
            formValue.Add("Id", professionalDevelopment.Id.ToString());
            formValue.Add("Name", professionalDevelopment.Name);
            formValue.Add("Color", professionalDevelopment.ColorInWebHex().Trim('#'));

            var controller = new GetOrganized.Controllers.TopicController();

            var result = controller.Create(formValue);
            Assert.AreEqual("토픽이 생성되었습니다.", controller.TempData["message"]);
        }
    }
}

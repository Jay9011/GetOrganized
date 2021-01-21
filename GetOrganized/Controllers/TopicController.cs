using GetOrganized.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GetOrganized.Controllers
{
    public class TopicController : Controller
    {
        //
        // GET: /Topic/
        public ActionResult Index()
        {
            ViewData.Model = Topic.Topics;

            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            var newTopic = new Topic();
            newTopic.Id = Convert.ToInt32(collection["Id"]);
            newTopic.Name = collection["Name"];
            newTopic.Color = ColorTranslator.FromHtml(collection["Color"]);

            Topic.Topics.Add(newTopic);
            TempData["message"] = "토픽이 생성되었습니다.";
            return RedirectToAction("Index");
        }
	}
}
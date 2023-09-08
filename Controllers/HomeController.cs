using React_server_side_demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace React_server_side_demo.Controllers
{
    public class HomeController : Controller
    {
        private static readonly IList<CommentModel> _comments;

        static HomeController()
        {
            _comments = new List<CommentModel>
            {
                new CommentModel
                {
                    Id = 1,
                    Author = "Madhu Mangal Mishra",
                    Text = "Attempted Server Side rendering with bundling and minification!"
                },
                new CommentModel
                {
                    Id = 2,
                    Author = "Tilak",
                    Text = "This is one comment"
                },
                new CommentModel
                {
                    Id = 3,
                    Author = "Varun Sarna",
                    Text = "This is another comment"
                },
            };
        }
        [OutputCache(Location = OutputCacheLocation.None)]
        public ActionResult Comments()
        {
            return Json(_comments, JsonRequestBehavior.AllowGet);
        }
        // GET: Home
        public ActionResult Index()
        {
            return View(_comments);
        }
    }
}
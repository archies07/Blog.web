using Blog.web.Data;
using Blog.web.Models.Domin;
using Blog.web.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace Blog.web.Controllers
{
    public class AdminController : Controller
    {
        private readonly blogdbcontext _blogdbcontext;
        public AdminController(blogdbcontext blogdbcontext)
        {
            _blogdbcontext = blogdbcontext;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Add")]
        public IActionResult submitTag(Addtagrequest addtagrequest)
        {
            //Mapping Addtagrequest to tag domain model
            var Tag = new Tag
            {
                Name = addtagrequest.Name,
                DisplayName = addtagrequest.DispalayName

            };

            _blogdbcontext.Tags.Add(Tag);
            _blogdbcontext.SaveChanges();

            return View("Add");
        }
    }
}

using Blog.Models.Domain;
using Blog.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using NeopeBlog.Data;
using System.ComponentModel;

namespace Blog.Controllers
{
    public class AdminTagsController : Controller
    {
        private readonly NeoDbContext _neoDbContext;

        public AdminTagsController(NeoDbContext neoDbContext)
        {
            _neoDbContext = neoDbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        //Below is using form to connect the data to the controller which is not a good approach 
        //I will use Model Binding next
        //[HttpPost]
        //[ActionName("Add")]
        // public IActionResult SubmitTag()
        //var name = Request.Form["name"];
        //var displayedName = Request.Form["displayName"]; 
        //return View("Add");
        //the name attribute of name="name" & name="displayName"

        
        //Using Model Bindng
          
        
        [HttpPost]
        public IActionResult Add(AddTagRequest addTagRequest)
        {
            //This was for display purpose to show that the value is coming back into the controller
            //var name = addTagRequest.Name;
            //var displayName = addTagRequest.DisplayName;
           
            //Mapping AddTagRequest to tag domain model
            var tag = new Tag
            {
                Name = addTagRequest.Name,
                DisplayedName = addTagRequest.DisplayedName

            };
            _neoDbContext.Tags.Add(tag);
            _neoDbContext.SaveChanges();

            return View("Add");
        }

    }
}
    
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC.Controllers
{
    public class HelloController : Controller   //This syntax tells us that the HelloController class extends the base Controller class.
    {
        // GET: /<controller>/
        [HttpGet]  //This conditions the display.  For a 'get' request, the form is shown.  After a 'post' request, Display() results are shown.
        public IActionResult Index()   // Index() is the method (function).  IActionResult defines how it behaves or what it can do.
        {
            string html = "<form method = 'post'>" +
                "<input type = 'text' name = 'name'/>" +
                "<input type = 'submit' value = 'Greet me!'/>" +
                "</form>";  //This could all have been contained on one line.  Returns used to improve readability.

            return Content(html, "text/html");
            //To redirect from a method, use return Redirect("/Hello/Goodbye");
        }

        // /Hello 
        [Route("/Hello")] //This routes the input from Index() through Display(), but the content appears in the /Hello window rather than /Hello/Display.
        [HttpPost]
        public IActionResult Display(string name)
        {                                   //Could replace the if() check by adding a default: Index(string name = "World")
            if (string.IsNullOrEmpty(name)) //Checks to is if there is a name parameter (/Hello/Index?name="blah").
            {
                return Content("<h1>Hello, World!</h1>", "text/html");  //Content is a method defined in IActionResult.
            }
            else
            {
                return Content(string.Format("<h1>Hello, {0}!</h1>", name), "text/html");
            }
        }

        // Handle requests to /Hello/NAME, where NAME is called a URL segment.  Ex: /Hello/Bob
        [Route("/Hello/{name}")]
        public IActionResult Index2(string name)
        {
            return Content(string.Format("<h1>Hello, {0}!</h1>", name), "text/html");
        }

        // The route for this action was first established as /Hello/Goodbye.
        // Updated the route to this controller to be /Hello/Aloha.
        [Route("/Hello/Aloha")]
        public IActionResult Goodbye()
        {
            return Content("Goodbye.");
        }
    }
}

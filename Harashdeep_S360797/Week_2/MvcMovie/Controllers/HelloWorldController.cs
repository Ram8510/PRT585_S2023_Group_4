using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
   public IActionResult Index()
{
    return View();
}
    // 
    // GET: /HelloWorld/Welcome /
    public string Greetings()
    {
        return "This is the Welcome action method...";
    }

    public int Age()
    {
        return 23; 
    }
}
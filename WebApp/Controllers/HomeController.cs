using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

  }
}
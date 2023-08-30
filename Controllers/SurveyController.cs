using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey.Controllers;

public class SurveyController : Controller
{
    [HttpGet]
    [Route("form")]

    public ViewResult MyForm()
    {
        return View("MyForm");
    }
    [HttpGet]
    [Route("display")]

    public ViewResult DisplayForm()
    {
        return View("DisplayForm");
    }


    [HttpPost]
    [Route("process")]
    public IActionResult Process(string name, string location, string language, string comment)
    {
        ViewBag.Name = name;
        ViewBag.Location = location;
        ViewBag.Language = language;
        ViewBag.Comment = comment;
        return View("DisplayForm");
    }

}
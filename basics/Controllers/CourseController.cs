using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;
//course
public class CourseController: Controller {
    //course/
    //course/index
    public IActionResult Index(){
        var kurs = new Course();
        kurs.Id = 1;
        kurs.Title = "Aspnet core kursu";
        kurs.Description = "güzel bir kurs";
        kurs.Image = "1.jpg";

        return View(kurs);
    }
    public IActionResult Details(){
        var kurs = new Course();
        kurs.Id = 1;
        kurs.Title = "Aspnet core kursu";
        kurs.Description = "güzel bir kurs";
        kurs.Image = "1.jpg";

        return View(kurs);
    }

    //course/list
    public IActionResult List(){
        return View("CourseList",Repository.Courses);
    }


}

using Microsoft.AspNetCore.Mvc;
namespace WebApplication2.Controllers

{
    public class MoviesController : Controller
    {
        public IActionResult GetMovie(int Id,string name) //(int[] arr) //?arr[0]=10 &arr[1]=90
        {
            return Content($"Movie with id :{Id} And Name IS : {name}");
        }
        public IActionResult index()
        {
            return Content ("Hello from index");
        }
        public IActionResult test()
        {
            return RedirectToAction(nameof(index));
        }

    }
}

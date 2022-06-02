using ExerciseWithManyToManyAtd.IndexViewModel;
using ExerciseWithManyToManyAtd.Services;
using Microsoft.AspNetCore.Mvc;

namespace ExerciseWithManyToManyAtd.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        public ServiceForEverything Service { get; set; }
        public HomeController(ServiceForEverything service)
        {
            Service= service;
        }
        public IActionResult Index()
        {
            ViewModel vm = new ViewModel(){
                ListOfUsers=Service.GetListUsers(),
                ListOfParties=Service.GetListParties(),
                PartiesWithUser=Service.GetListOfUsersAndParties(),
            };
            return View(vm);
        }

        [HttpPost("AddUser")]

        public IActionResult AddUs(string name, string surname,int clubId)
        {
            Service.AddUser(name, surname, clubId);
          return RedirectToAction("Index");  
        }

        [HttpPost("AddParty")]
        public IActionResult AddParty(string name)
        {
            Service.AddParty(name);
            return RedirectToAction("Index");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using OrientationExamTryJava.IndexViewModel;
using OrientationExamTryJava.Models;
using OrientationExamTryJava.Services;
using System.Text.Json.Serialization;

namespace OrientationExamTryJava.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
		public AliasService AliasService { get; set; }
        public HomeController(AliasService aliasService)
		{
            AliasService = aliasService;    
		}
        public IActionResult Index()
        {
            ViewModel vm = new ViewModel()
            {
                IsInDb = false,
			};
            return View("Index",vm);
        }

        [HttpPost("save-link")]
        public IActionResult Save(string url, string alias)
        {
            Aliaser al = new Aliaser(url, alias, AliasService.GenerateRandomNo());
            ViewModel vm = new ViewModel()
			{
                CurrentAliaser = al
            };
            if (AliasService.GetList().Any(a => a.Alias == alias))
			{
                vm.IsInDb= true;
			}
            else
			{
            AliasService.Add(al);
			}
           
            return View("Index",vm);
        }

        [HttpGet("a/{alias}")]

        public IActionResult alias(string alias)
        {
           Aliaser? al=AliasService.GetList().FirstOrDefault(a=> a.Alias == alias);
            if (al is not null)
			{
                AliasService.FindAndChange(alias);
                return Redirect(al.Url);
			}
            else
			{
                return StatusCode(404);
            }
        }

        [HttpGet("api/links")]
        public IActionResult links()
        {
            return Ok( AliasService.GetList());
        }

        [HttpDelete("api/links/{id}")]
        public IActionResult links(int id,[FromBody] SecretCode secretCode)
        {
            return StatusCode(AliasService.DeleteAlias(id,secretCode.secretCode));
        }
    }
}

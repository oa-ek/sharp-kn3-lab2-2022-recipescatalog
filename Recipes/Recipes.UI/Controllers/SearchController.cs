using Microsoft.AspNetCore.Mvc;
using Recipes.Repos;
using Newtonsoft.Json;
using Recipes.Core;
using System.Diagnostics;

namespace Recipes.UI.Controllers
{
    public class SearchController : Controller
    {
        private readonly InfoDishRepository infoDishRepository;

        public SearchController(InfoDishRepository infoDishRepository)
        {
            this.infoDishRepository = infoDishRepository;
        }

        public async Task<IActionResult> SearchInfoDish(string infoDishname)
        {
            if (String.IsNullOrEmpty(infoDishname))
            {
                return RedirectToAction("SearchError");
            }
            var list = infoDishRepository.GetInfoDishes();
            list = list.
                Where(x => x.Title.ToLower().Contains(infoDishname.ToLower())
                || x.Ingredients1.ToLower().Contains(infoDishname.ToLower())
                || x.Ingredients2.ToLower().Contains(infoDishname.ToLower())
                || x.Ingredients3.ToLower().Contains(infoDishname.ToLower())
                || x.Ingredients4.ToLower().Contains(infoDishname.ToLower())
                || x.Ingredients5.ToLower().Contains(infoDishname.ToLower())
                || x.Ingredients6.ToLower().Contains(infoDishname.ToLower())
                || x.Ingredients7.ToLower().Contains(infoDishname.ToLower())
                || x.Ingredients8.ToLower().Contains(infoDishname.ToLower())
                || x.CookingTime.ToString().Contains(infoDishname.ToLower())
                || x.Difficulty.ToString().Contains(infoDishname.ToLower())
                || x.Categories.NameCategory.ToLower().Contains(infoDishname.ToLower())).ToList();

            ViewBag.InfoDishes = list;

            return View("Index");
        }

        public IActionResult SearchError()
        {
            ViewBag.Message = "Пошукова стрічка не може бути пустою";
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using BoardApp.Models;


namespace BoardApp.Controllers
{
    public class BoardController : Controller
    {
        public IActionResult Index()
        {
            return View(Repository.Boards);
        }

        public IActionResult Details(string id)
        {
            var board = Repository.Boards.FirstOrDefault(b => b.BoardCode == id);
            return View(board);
        }
    }
}
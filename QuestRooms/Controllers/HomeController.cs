using Microsoft.AspNetCore.Mvc;
using QuestRooms.Models;

namespace QuestRooms.Controllers
{
    public class HomeController : Controller
    {
        private IRoomsRepository repository;

        public HomeController (IRoomsRepository repository) {
            this.repository = repository;
        }
        public ViewResult Index()
        {
            return View(repository.Rooms);
        }
    }
}
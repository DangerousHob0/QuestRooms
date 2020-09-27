using Microsoft.AspNetCore.Mvc;
using QuestRooms.Models;
using System.Linq;
using QuestRooms.Models.ViewModels;

namespace QuestRooms.Controllers
{
    public class HomeController : Controller
    {
        private IRoomsRepository repository;
        public int PageSize = 3;

        public HomeController(IRoomsRepository repository)
        {
            this.repository = repository;
        }
        // public ViewResult Index(int questPage = 1) => View(repository.Rooms
        // .OrderBy(p => p.QuestId)
        // .Skip((questPage - 1) * PageSize)
        // .Take(PageSize));
        public ViewResult Index (int roomPage = 1)
        => View(new RoomsListViewModel
        {
            Rooms = repository.Rooms.OrderBy(p => p.QuestId).Skip((roomPage - 1) * PageSize).Take(PageSize),
            PagingInfo = new PagingInfo
            {
                CurrentPage = roomPage,
                ItemsPerPage = PageSize,
                TotalItems = repository.Rooms.Count()
            }
        });
        public ViewResult Room (int questId) => View(repository.Rooms.First(r => r.QuestId == questId));
    }
}
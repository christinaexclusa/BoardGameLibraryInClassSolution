using BoardGameLibraryInClass.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BoardGameLibraryInClass.Controllers
{

    public class PublisherController : Controller
    {
        private readonly GameContext _context;

        public PublisherController(GameContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var publishers = _context.Publishers.Include(b => b.BoardGames).ToList();
            return View(publishers);
        }

        public IActionResult Details(int id)
        {
            var publisher = _context.Publishers.Where(p => p.Id == id).Include(b => b.BoardGames).FirstOrDefault();

            return View(publisher);
        }
    }
}

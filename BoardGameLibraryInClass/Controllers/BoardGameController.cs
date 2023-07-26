using BoardGameLibraryInClass.Data;
using BoardGameLibraryInClass.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BoardGameLibraryInClass.Controllers
{
    
    public class BoardGameController : Controller
    {
        private readonly GameContext _context;
        public BoardGameController(GameContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            return View(_context.BoardGames.Include(p => p.Publisher).ToList());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(BoardGameModel boardGame)
        {
            if (ModelState.IsValid)
            {

                boardGame.PublisherId = GetPublisher(boardGame.NewPublisher);
                _context.BoardGames.Add(boardGame);
                _context.SaveChanges();
                return RedirectToAction("Index");


            }
            return View(boardGame);

        }

        private int GetPublisher(string publisher)
        {
            PublisherModel? pub = null;
            pub = _context.Publishers.Where(p => p.Name.ToLower() == publisher.ToLower()).FirstOrDefault();
            if(pub == null)
            {
                pub = new PublisherModel { Name = publisher };
                _context.Add(pub);
                _context.SaveChanges();
            }
            return pub.Id;
        }
    }
}

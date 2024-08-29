using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunGroopWebApp.Data;
using RunGroopWebApp.Interfaces;
using RunGroopWebApp.Models;

namespace RunGroopWebApp.Controllers
{
    public class RaceController : Controller
    {
        //private readonly ApplicationDbContext _context;
        private readonly IRaceRepository _raceRepository;

        //public RaceController(ApplicationDbContext context)
        public RaceController(IRaceRepository raceRepository)
        {
            //_context = context;
            _raceRepository = raceRepository;
        }
        //public IActionResult Index()
        public async Task<IActionResult> Index()
        {
            //var races = _context.Races.ToList();
            IEnumerable<Race> races = await _raceRepository.GetAll();
            return View(races);
        }
        //public IActionResult Detail(int id)
        public async Task<IActionResult> Detail(int id)
        {               
            //Race race = _context.Races.Include(a => a.Address).FirstOrDefault(c => c.Id == id);
            Race race = await _raceRepository.GetByIdAsync(id);
            return View(race);
        }
    }
}

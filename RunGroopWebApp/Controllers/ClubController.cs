using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunGroopWebApp.Data;
using RunGroopWebApp.Interfaces;
using RunGroopWebApp.Models;

namespace RunGroopWebApp.Controllers
{
    public class ClubController : Controller
    {
        //private readonly ApplicationDbContext _context;
        private readonly IClubRepository _clubRepository;

        //public ClubController(ApplicationDbContext context)
        public ClubController(IClubRepository clubRepository)
        {
            _clubRepository = clubRepository;
        }
        //public IActionResult Index()
        public async Task<IActionResult> Index()
        {
            //var clubs = _context.Clubs.ToList();
            IEnumerable<Club> clubs = await _clubRepository.GetAll();
            return View(clubs);
        }
        //public IActionResult Detail(int id)
        public async Task<IActionResult> Detail(int id)
        {
            //Club club = _context.Clubs.Include(a => a.Address).FirstOrDefault(c => c.Id == id);
            Club club = await _clubRepository.GetByIdAsync(id);
            return View(club);
        }
    }
}

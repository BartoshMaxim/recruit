using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Recruter.Data;
using Recruter.ViewModels;

namespace Recruter.Controllers
{
    [Authorize(Roles = "Admin,Recruiter")]
    public class VacancyController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<User> _userManager;
        
        public VacancyController(ApplicationDbContext dbContext, UserManager<User> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }
        
        public IActionResult Index()
        {
            var vacancies = _dbContext.Vacancies.Where(v => v.User.Id.Equals(_userManager.GetUserId(User))).Skip(0).Take(50).ToList();
            
            return View(vacancies);
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return View(new VacancyViewModel());
        }
        
        [HttpPost]
        public IActionResult Create(VacancyViewModel vacancyViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = _userManager.GetUserAsync(User).Result;
                
                var vacancy = new Vacancy
                {
                    User = user,
                    Title = vacancyViewModel.Title,
                    Salary = vacancyViewModel.Salary,
                    Location = vacancyViewModel.Location,
                    Description = vacancyViewModel.Description
                };

                _dbContext.Add(vacancy);

                _dbContext.SaveChanges();
                
                return View("Index");
            }
            
            return View(vacancyViewModel);
        }
        
        [HttpGet]
        public IActionResult Update(int id)
        {
            var vacancy = _dbContext.Vacancies.FirstOrDefault(v => v.VacancyId.Equals(id));
            
            return View(new VacancyViewModel(vacancy));
        }
        
        [HttpPost]
        public IActionResult Update(VacancyViewModel vacancyViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = _userManager.GetUserAsync(User).Result;
                
                var vacancy = new Vacancy
                {
                    VacancyId = vacancyViewModel.Id,
                    User = user,
                    Title = vacancyViewModel.Title,
                    Salary = vacancyViewModel.Salary,
                    Location = vacancyViewModel.Location,
                    Description = vacancyViewModel.Description
                };

                _dbContext.Update(vacancy);

                _dbContext.SaveChanges();
            }
            
            return View(vacancyViewModel);
        }
        
        [HttpGet]
        public IActionResult Detail(int id)
        {
            var vacancy = _dbContext.Vacancies.FirstOrDefault(v => v.VacancyId.Equals(id));
            
            return View(vacancy);
        }
    }
}
using System.ComponentModel.DataAnnotations;
using Recruter.Data;

namespace Recruter.ViewModels
{
    public class VacancyViewModel
    {
        public VacancyViewModel()
        {
            
        }
        
        public VacancyViewModel(Vacancy vacancy)
        {
            Id = vacancy.VacancyId;
            Title = vacancy.Title;
            Salary = vacancy.Salary;
            Description = vacancy.Description;
            Location = vacancy.Location;
        }
        
        public int Id { get; set; }
        
        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Salary")]
        public int? Salary { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Location")]
        public string Location { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Recruter.Data
{
    public class Vacancy
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VacancyId { get; set; }
        
        public string Title { get; set; }
        
        public int? Salary { get; set; }
        
        public string Description { get; set; }
        
        public string Location { get; set; }
        
        public User User { get; set; }
    }
}
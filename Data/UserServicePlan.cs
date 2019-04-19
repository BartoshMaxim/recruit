using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Recruter.Data
{
    public class UserServicePlan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserServicePlanId { get; set; }
        
        public string Name { get; set; }
        
        public string Description { get; set; }
        
        public int CountDays { get; set; }
        
        public int CountVacancies { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Recruter.Data
{
    public class FirmServicePlan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FirmServicePlanId { get; set; }

        public string Name { get; set; }
        
        public string Description { get; set; }
        
        public int? CountDays { get; set; }
        
        public int CountVacancies { get; set; }
        
        public int CountUsers { get; set; }
        
        public int Price { get; set; }
    }
}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Recruter.Data
{
    public class Firm
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FirmId { get; set; }

        public string Name { get; set; }
        
        public string Email { get; set; }
        
        public string Description { get; set; }
        
        public byte[] Logo { get; set; }
        
        public List<User> Users { get; set; }
    }
}
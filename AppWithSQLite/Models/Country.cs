using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AppWithSQLite.Models
{
    public class Country
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public ICollection<Project> Projects { get; set; }
    }
}
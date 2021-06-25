using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWithSQLite.Models
{
    public class Project
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public DateTime DateCreate { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int CountryId { get; set; }

        public Country Country { get; set; }
    }
}

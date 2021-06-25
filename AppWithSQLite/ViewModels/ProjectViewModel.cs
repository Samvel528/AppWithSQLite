using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWithSQLite.ViewModels
{
    public class ProjectViewModel
    {
        public int Id { get; set; }

        public DateTime DateCreate { get; set; }

        public string Name { get; set; }

        public string CountryName { get; set; }
    }
}

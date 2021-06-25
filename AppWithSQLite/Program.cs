using AppWithSQLite.Database;
using AppWithSQLite.Repositories;
using AppWithSQLite.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWithSQLite
{
    static class Program
    {
        private static readonly AppDbContext _context = new AppDbContext();
        private static readonly IRepository _repository = new SQLiteRepository(_context);
        private static readonly ProjectsService _service = new ProjectsService(_repository, _context);
        public static ProjectsService Service
        {
            get { return _service; }
        }

        private static readonly frm_Projects _frm_Projects = new frm_Projects(Service);
        public static frm_Projects Frm_Projects
        {
            get { return _frm_Projects; }
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Frm_Projects);
        }
    }
}

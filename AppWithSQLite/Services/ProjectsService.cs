using AppWithSQLite.Database;
using AppWithSQLite.Models;
using AppWithSQLite.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWithSQLite.Services
{
    public class ProjectsService
    {
        private readonly IRepository _repository;
        private readonly AppDbContext _context;

        public ProjectsService(IRepository repository, AppDbContext context)
        {
            _repository = repository;
            _context = context;
        }

        public void Add(Project project)
        {
            var dbCountry = _context.Countries.FirstOrDefault(c => c.Name == project.Country.Name);

            if (dbCountry != null)
            {
                project.Country = dbCountry;
            }
            else
            {
                _repository.Add(project.Country);
            }
            _repository.Add(project);
        }

        public void Update(Project project)
        {
            var dbCountry = _context.Countries.FirstOrDefault(c => c.Name == project.Country.Name);
            
            if (dbCountry != null)
            {
                project.Country = dbCountry;
            }
            else
            {
                _repository.Add(project.Country);
            }

            _repository.Update(project);
        }

        public void Delete(int id)
        {
            var project = _repository.SelectById<Project>(id);
            if(project != null)
            {
                _repository.Delete(project);
            }
        }

        public List<Project> GetProjects()
        {
            return _repository.SelectAll<Project>();
        }

        public List<Project> GetProjectsWithCountry()
        {
            return _context.Projects.Include(c => c.Country).ToList();
        }

        public Project GetProjectById(int id)
        {
            return _context.Projects.FirstOrDefault(p => p.Id == id);
        }
    }
}

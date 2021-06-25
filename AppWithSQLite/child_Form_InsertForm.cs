using AppWithSQLite.Database;
using AppWithSQLite.Models;
using AppWithSQLite.Repositories;
using AppWithSQLite.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWithSQLite
{
    public partial class child_Form_InsertForm : Form
    {
        private readonly ProjectsService _projectsService;

        public child_Form_InsertForm(ProjectsService projectsService)
        {
            InitializeComponent();
            _projectsService = projectsService;
        }

        private void child_Form_InsertForm_Load(object sender, EventArgs e)
        {
            tb_DateCreate.Text = DateTime.Now.ToString();
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            var project = GetProject();
            _projectsService.Add(project);
            this.Close();
        }

        private Project GetProject()
        {
            Project project = new Project();
            project.Name = tb_Name.Text;
            project.DateCreate = Convert.ToDateTime(tb_DateCreate.Text);
            project.Country = GetCountry();

            return project;
        }

        private Country GetCountry()
        {
            Country country = new Country();
            country.Name = tb_CountryName.Text;

            return country;
        }
    }
}

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
    public partial class child_Form_UpdateForm : Form
    {
        private ProjectsService _projectsService;
        private Project _project;

        public child_Form_UpdateForm(ProjectsService projectService, Project project)
        {
            InitializeComponent();
            _projectsService = projectService;
            _project = project;

        }

        private void child_Form_UpdateForm_Load(object sender, EventArgs e)
        {
            ShowProject(_project);
        }

        private void ShowProject(Project project)
        {
            tb_Name.Text = _project.Name;
            tb_DateCreate.Text = _project.DateCreate.ToString();
            tb_CountryName.Text = _project.Country.Name;
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Project GetProjectFromView()
        {
            Project project = new Project()
            {
                Id = _project.Id,
                Name = tb_Name.Text,
                DateCreate = Convert.ToDateTime(tb_DateCreate.Text),
                Country = GetCountry()
            };

            return project;
        }

        private Country GetCountry()
        {
            Country country = new Country()
            {
                Name = tb_CountryName.Text
            };

            return country;
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            var project = GetProjectFromView();
            _projectsService.Update(project);
            this.Close();
        }
    }
}

using AppWithSQLite.Database;
using AppWithSQLite.Models;
using AppWithSQLite.Repositories;
using AppWithSQLite.Services;
using AppWithSQLite.ViewModels;
using Microsoft.EntityFrameworkCore;
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
    public partial class frm_Projects : Form
    {
        private readonly ProjectsService _projectsService;

        public frm_Projects(ProjectsService projectsService)
        {
            InitializeComponent();
            _projectsService = projectsService;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateView();
        }

        private List<ProjectViewModel> GetProjectViewModels()
        {
            List<ProjectViewModel> projectViewModels = new List<ProjectViewModel>();
            var entites = _projectsService.GetProjectsWithCountry();
            
            foreach(var entity in entites)
            {
                var model = GetProjectViewModel(entity);

                projectViewModels.Add(model);
            }

            return projectViewModels;
        }

        private void bt_Insert_Click(object sender, EventArgs e)
        {
            child_Form_InsertForm insertForm = new child_Form_InsertForm(_projectsService);
            insertForm.ShowDialog();
            UpdateView();
        }

        private void bt_Update_Click(object sender, EventArgs e)
        {
            if (lb_Id.Text != "(Id)")
            {
                var model = _projectsService.GetProjectById(int.Parse(lb_Id.Text));
                child_Form_UpdateForm updateForm = new child_Form_UpdateForm(_projectsService, model);
                updateForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select project!");
            }

            UpdateView();
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            if (lb_Id.Text != "(Id)")
            {
                _projectsService.Delete(int.Parse(lb_Id.Text));
            }
            else
            {
                MessageBox.Show("Please select project!");
            }

            UpdateView();
        }

        private void dgv_Projects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dgv_Projects.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgv_Projects.CurrentRow.Selected = true;
                lb_Id.Text = dgv_Projects.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            }
        }

        private ProjectViewModel GetProjectViewModel(Project project)
        {
            ProjectViewModel model = new ProjectViewModel()
            {
                Id = project.Id,
                Name = project.Name,
                DateCreate = project.DateCreate,
                CountryName = project.Country.Name
            };

            return model;
        }

        private void UpdateView()
        {
            dgv_Projects.DataSource = GetProjectViewModels();
        }
    }
}

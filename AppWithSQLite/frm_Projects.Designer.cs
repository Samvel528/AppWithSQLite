
namespace AppWithSQLite
{
    partial class frm_Projects
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_Projects = new System.Windows.Forms.DataGridView();
            this.bt_Update = new System.Windows.Forms.Button();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.bt_Insert = new System.Windows.Forms.Button();
            this.lb_Id = new System.Windows.Forms.Label();
            this.lb_Select = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Projects)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Projects
            // 
            this.dgv_Projects.AllowUserToAddRows = false;
            this.dgv_Projects.AllowUserToDeleteRows = false;
            this.dgv_Projects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Projects.Location = new System.Drawing.Point(12, 12);
            this.dgv_Projects.Name = "dgv_Projects";
            this.dgv_Projects.ReadOnly = true;
            this.dgv_Projects.RowHeadersWidth = 51;
            this.dgv_Projects.RowTemplate.Height = 29;
            this.dgv_Projects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Projects.Size = new System.Drawing.Size(776, 384);
            this.dgv_Projects.TabIndex = 0;
            this.dgv_Projects.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Projects_CellClick);
            // 
            // bt_Update
            // 
            this.bt_Update.Location = new System.Drawing.Point(152, 409);
            this.bt_Update.Name = "bt_Update";
            this.bt_Update.Size = new System.Drawing.Size(134, 29);
            this.bt_Update.TabIndex = 11;
            this.bt_Update.Text = "Update";
            this.bt_Update.UseVisualStyleBackColor = true;
            this.bt_Update.Click += new System.EventHandler(this.bt_Update_Click);
            // 
            // bt_Delete
            // 
            this.bt_Delete.Location = new System.Drawing.Point(292, 409);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(134, 29);
            this.bt_Delete.TabIndex = 10;
            this.bt_Delete.Text = "Delete";
            this.bt_Delete.UseVisualStyleBackColor = true;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // bt_Insert
            // 
            this.bt_Insert.Location = new System.Drawing.Point(12, 409);
            this.bt_Insert.Name = "bt_Insert";
            this.bt_Insert.Size = new System.Drawing.Size(134, 29);
            this.bt_Insert.TabIndex = 9;
            this.bt_Insert.Text = "Insert";
            this.bt_Insert.UseVisualStyleBackColor = true;
            this.bt_Insert.Click += new System.EventHandler(this.bt_Insert_Click);
            // 
            // lb_Id
            // 
            this.lb_Id.AutoSize = true;
            this.lb_Id.Location = new System.Drawing.Point(756, 418);
            this.lb_Id.Name = "lb_Id";
            this.lb_Id.Size = new System.Drawing.Size(32, 20);
            this.lb_Id.TabIndex = 12;
            this.lb_Id.Text = "(Id)";
            // 
            // lb_Select
            // 
            this.lb_Select.AutoSize = true;
            this.lb_Select.Location = new System.Drawing.Point(671, 418);
            this.lb_Select.Name = "lb_Select";
            this.lb_Select.Size = new System.Drawing.Size(79, 20);
            this.lb_Select.TabIndex = 13;
            this.lb_Select.Text = "Selected #";
            // 
            // frm_Projects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_Select);
            this.Controls.Add(this.lb_Id);
            this.Controls.Add(this.bt_Update);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.bt_Insert);
            this.Controls.Add(this.dgv_Projects);
            this.Name = "frm_Projects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projects";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Projects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Projects;
        private System.Windows.Forms.Button bt_Update;
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.Button bt_Insert;
        private System.Windows.Forms.Label lb_Id;
        private System.Windows.Forms.Label lb_Select;
    }
}


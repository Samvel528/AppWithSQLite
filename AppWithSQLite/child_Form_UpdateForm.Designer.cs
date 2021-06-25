
namespace AppWithSQLite
{
    partial class child_Form_UpdateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_CountryName = new System.Windows.Forms.Label();
            this.lb_DateCreate = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_DateCreate = new System.Windows.Forms.TextBox();
            this.tb_CountryName = new System.Windows.Forms.TextBox();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(60, 19);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(49, 20);
            this.lb_Name.TabIndex = 0;
            this.lb_Name.Text = "Name";
            // 
            // lb_CountryName
            // 
            this.lb_CountryName.AutoSize = true;
            this.lb_CountryName.Location = new System.Drawing.Point(9, 84);
            this.lb_CountryName.Name = "lb_CountryName";
            this.lb_CountryName.Size = new System.Drawing.Size(100, 20);
            this.lb_CountryName.TabIndex = 1;
            this.lb_CountryName.Text = "CountryName";
            // 
            // lb_DateCreate
            // 
            this.lb_DateCreate.AutoSize = true;
            this.lb_DateCreate.Location = new System.Drawing.Point(25, 50);
            this.lb_DateCreate.Name = "lb_DateCreate";
            this.lb_DateCreate.Size = new System.Drawing.Size(84, 20);
            this.lb_DateCreate.TabIndex = 2;
            this.lb_DateCreate.Text = "DateCreate";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(126, 12);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(159, 27);
            this.tb_Name.TabIndex = 3;
            // 
            // tb_DateCreate
            // 
            this.tb_DateCreate.Location = new System.Drawing.Point(126, 47);
            this.tb_DateCreate.Name = "tb_DateCreate";
            this.tb_DateCreate.ReadOnly = true;
            this.tb_DateCreate.Size = new System.Drawing.Size(159, 27);
            this.tb_DateCreate.TabIndex = 4;
            // 
            // tb_CountryName
            // 
            this.tb_CountryName.Location = new System.Drawing.Point(126, 81);
            this.tb_CountryName.Name = "tb_CountryName";
            this.tb_CountryName.Size = new System.Drawing.Size(159, 27);
            this.tb_CountryName.TabIndex = 5;
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Location = new System.Drawing.Point(59, 121);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(94, 29);
            this.bt_Cancel.TabIndex = 6;
            this.bt_Cancel.Text = "Cancel";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // bt_Save
            // 
            this.bt_Save.Location = new System.Drawing.Point(159, 121);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(94, 29);
            this.bt_Save.TabIndex = 7;
            this.bt_Save.Text = "Save";
            this.bt_Save.UseVisualStyleBackColor = true;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // child_Form_UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 158);
            this.Controls.Add(this.bt_Save);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.tb_CountryName);
            this.Controls.Add(this.tb_DateCreate);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lb_DateCreate);
            this.Controls.Add(this.lb_CountryName);
            this.Controls.Add(this.lb_Name);
            this.Name = "child_Form_UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Form";
            this.Load += new System.EventHandler(this.child_Form_UpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_CountryName;
        private System.Windows.Forms.Label lb_DateCreate;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_DateCreate;
        private System.Windows.Forms.TextBox tb_CountryName;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Button bt_Save;
    }
}
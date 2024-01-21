namespace Fubis.View.Admin
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.bicycleManagementButton = new System.Windows.Forms.Button();
            this.districtManagementButton = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bicycleManagementButton
            // 
            this.bicycleManagementButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.bicycleManagementButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bicycleManagementButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bicycleManagementButton.FlatAppearance.BorderSize = 0;
            this.bicycleManagementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bicycleManagementButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bicycleManagementButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.bicycleManagementButton.Location = new System.Drawing.Point(8, 226);
            this.bicycleManagementButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bicycleManagementButton.Name = "bicycleManagementButton";
            this.bicycleManagementButton.Size = new System.Drawing.Size(180, 40);
            this.bicycleManagementButton.TabIndex = 0;
            this.bicycleManagementButton.Text = "Bisiklet Yönetimi";
            this.bicycleManagementButton.UseVisualStyleBackColor = false;
            this.bicycleManagementButton.Click += new System.EventHandler(this.bicycleManagementButton_Click);
            // 
            // districtManagementButton
            // 
            this.districtManagementButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.districtManagementButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.districtManagementButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.districtManagementButton.FlatAppearance.BorderSize = 0;
            this.districtManagementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.districtManagementButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.districtManagementButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.districtManagementButton.Location = new System.Drawing.Point(8, 279);
            this.districtManagementButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.districtManagementButton.Name = "districtManagementButton";
            this.districtManagementButton.Size = new System.Drawing.Size(180, 40);
            this.districtManagementButton.TabIndex = 2;
            this.districtManagementButton.Text = "İlçe Yönetimi";
            this.districtManagementButton.UseVisualStyleBackColor = false;
            this.districtManagementButton.Click += new System.EventHandler(this.districtManagementButton_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.panelContainer.Location = new System.Drawing.Point(197, 6);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(822, 588);
            this.panelContainer.TabIndex = 3;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitButton.ForeColor = System.Drawing.Color.Transparent;
            this.exitButton.Location = new System.Drawing.Point(8, 548);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(180, 40);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Çıkış Yap";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.districtManagementButton);
            this.Controls.Add(this.bicycleManagementButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.BicycleManagementForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bicycleManagementButton;
        private System.Windows.Forms.Button districtManagementButton;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button exitButton;
    }
}
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
            this.SuspendLayout();
            // 
            // bicycleManagementButton
            // 
            this.bicycleManagementButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.bicycleManagementButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bicycleManagementButton.FlatAppearance.BorderSize = 0;
            this.bicycleManagementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bicycleManagementButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bicycleManagementButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.bicycleManagementButton.Location = new System.Drawing.Point(8, 196);
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
            this.districtManagementButton.FlatAppearance.BorderSize = 0;
            this.districtManagementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.districtManagementButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.districtManagementButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.districtManagementButton.Location = new System.Drawing.Point(8, 242);
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
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelContainer.Location = new System.Drawing.Point(196, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(828, 600);
            this.panelContainer.TabIndex = 3;
            // 
            // BicycleManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.districtManagementButton);
            this.Controls.Add(this.bicycleManagementButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BicycleManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.BicycleManagementForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bicycleManagementButton;
        private System.Windows.Forms.Button districtManagementButton;
        private System.Windows.Forms.Panel panelContainer;
    }
}
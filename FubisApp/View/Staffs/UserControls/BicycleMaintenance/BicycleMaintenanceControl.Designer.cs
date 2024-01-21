namespace Fubis.View.Staffs.UserControls.BicycleMaintenance
{
    partial class BicycleMaintenanceControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.finishMaintenanceButton = new System.Windows.Forms.Button();
            this.startMaintenanceButton = new System.Windows.Forms.Button();
            this.bicycleDataGridView = new System.Windows.Forms.DataGridView();
            this.staffInformationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bicycleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // finishMaintenanceButton
            // 
            this.finishMaintenanceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finishMaintenanceButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.finishMaintenanceButton.Location = new System.Drawing.Point(599, 483);
            this.finishMaintenanceButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.finishMaintenanceButton.Name = "finishMaintenanceButton";
            this.finishMaintenanceButton.Size = new System.Drawing.Size(201, 35);
            this.finishMaintenanceButton.TabIndex = 15;
            this.finishMaintenanceButton.Text = "Bakımı Bitir";
            this.finishMaintenanceButton.UseVisualStyleBackColor = true;
            // 
            // startMaintenanceButton
            // 
            this.startMaintenanceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startMaintenanceButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startMaintenanceButton.Location = new System.Drawing.Point(27, 483);
            this.startMaintenanceButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.startMaintenanceButton.Name = "startMaintenanceButton";
            this.startMaintenanceButton.Size = new System.Drawing.Size(201, 35);
            this.startMaintenanceButton.TabIndex = 14;
            this.startMaintenanceButton.Text = "Bakımı Başlat";
            this.startMaintenanceButton.UseVisualStyleBackColor = true;
            // 
            // bicycleDataGridView
            // 
            this.bicycleDataGridView.AllowUserToAddRows = false;
            this.bicycleDataGridView.AllowUserToDeleteRows = false;
            this.bicycleDataGridView.AllowUserToOrderColumns = true;
            this.bicycleDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.bicycleDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bicycleDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bicycleDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bicycleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bicycleDataGridView.Location = new System.Drawing.Point(27, 108);
            this.bicycleDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bicycleDataGridView.Name = "bicycleDataGridView";
            this.bicycleDataGridView.ReadOnly = true;
            this.bicycleDataGridView.Size = new System.Drawing.Size(774, 340);
            this.bicycleDataGridView.TabIndex = 17;
            // 
            // staffInformationLabel
            // 
            this.staffInformationLabel.AutoSize = true;
            this.staffInformationLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.staffInformationLabel.Location = new System.Drawing.Point(22, 70);
            this.staffInformationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.staffInformationLabel.Name = "staffInformationLabel";
            this.staffInformationLabel.Size = new System.Drawing.Size(176, 21);
            this.staffInformationLabel.TabIndex = 18;
            this.staffInformationLabel.Text = "Serhat Erdem - Merkez";
            // 
            // BicycleMaintenanceControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.staffInformationLabel);
            this.Controls.Add(this.bicycleDataGridView);
            this.Controls.Add(this.finishMaintenanceButton);
            this.Controls.Add(this.startMaintenanceButton);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "BicycleMaintenanceControl";
            this.Size = new System.Drawing.Size(822, 588);
            this.Load += new System.EventHandler(this.BicycleMaintenanceControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bicycleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button finishMaintenanceButton;
        private System.Windows.Forms.Button startMaintenanceButton;
        private System.Windows.Forms.DataGridView bicycleDataGridView;
        private System.Windows.Forms.Label staffInformationLabel;
    }
}

namespace Fubis.View.Admin.UserControls.BicycleManagement
{
    partial class BicycleManagementControl
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
            this.bicycleDataGridView = new System.Windows.Forms.DataGridView();
            this.districtListBox = new System.Windows.Forms.ListBox();
            this.serviceStaffInformationLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.addField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bicycleDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.bicycleDataGridView.Location = new System.Drawing.Point(90, 78);
            this.bicycleDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bicycleDataGridView.Name = "bicycleDataGridView";
            this.bicycleDataGridView.ReadOnly = true;
            this.bicycleDataGridView.Size = new System.Drawing.Size(400, 466);
            this.bicycleDataGridView.TabIndex = 0;
            // 
            // districtListBox
            // 
            this.districtListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.districtListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.districtListBox.FormattingEnabled = true;
            this.districtListBox.ItemHeight = 21;
            this.districtListBox.Location = new System.Drawing.Point(550, 78);
            this.districtListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.districtListBox.Name = "districtListBox";
            this.districtListBox.Size = new System.Drawing.Size(186, 252);
            this.districtListBox.TabIndex = 1;
            this.districtListBox.SelectedIndexChanged += new System.EventHandler(this.districtListBox_SelectedIndexChanged);
            // 
            // serviceStaffInformationLabel
            // 
            this.serviceStaffInformationLabel.AutoSize = true;
            this.serviceStaffInformationLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.serviceStaffInformationLabel.Location = new System.Drawing.Point(87, 45);
            this.serviceStaffInformationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.serviceStaffInformationLabel.Name = "serviceStaffInformationLabel";
            this.serviceStaffInformationLabel.Size = new System.Drawing.Size(207, 17);
            this.serviceStaffInformationLabel.TabIndex = 2;
            this.serviceStaffInformationLabel.Text = "Teknik servis sorumlusu: Berkant";
            this.serviceStaffInformationLabel.Visible = false;
            // 
            // deleteButton
            // 
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.Location = new System.Drawing.Point(560, 587);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(186, 35);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Kaldır";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addButton.Location = new System.Drawing.Point(549, 509);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(186, 35);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Ekle";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // addField
            // 
            this.addField.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addField.Location = new System.Drawing.Point(550, 439);
            this.addField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addField.Name = "addField";
            this.addField.Size = new System.Drawing.Size(186, 29);
            this.addField.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(550, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Bisiklet Adet";
            // 
            // BicycleManagementControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addField);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.serviceStaffInformationLabel);
            this.Controls.Add(this.districtListBox);
            this.Controls.Add(this.bicycleDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "BicycleManagementControl";
            this.Size = new System.Drawing.Size(822, 588);
            this.Load += new System.EventHandler(this.BicycleManagementControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bicycleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bicycleDataGridView;
        private System.Windows.Forms.ListBox districtListBox;
        private System.Windows.Forms.Label serviceStaffInformationLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox addField;
        private Label label1;
    }
}

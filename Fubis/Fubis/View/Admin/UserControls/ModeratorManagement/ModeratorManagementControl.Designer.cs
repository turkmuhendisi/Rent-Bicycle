namespace Fubis.View.Admin.ModeratorManagement
{
    partial class ModeratorManagementControl
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
            this.firstNameField = new System.Windows.Forms.TextBox();
            this.lastNameField = new System.Windows.Forms.TextBox();
            this.moderatorRadioButton = new System.Windows.Forms.RadioButton();
            this.serviceRadioButton = new System.Windows.Forms.RadioButton();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.districtListBox = new System.Windows.Forms.ListBox();
            this.bicycleDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bicycleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameField
            // 
            this.firstNameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstNameField.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.firstNameField.Location = new System.Drawing.Point(409, 160);
            this.firstNameField.Name = "firstNameField";
            this.firstNameField.Size = new System.Drawing.Size(193, 22);
            this.firstNameField.TabIndex = 0;
            // 
            // lastNameField
            // 
            this.lastNameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastNameField.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lastNameField.Location = new System.Drawing.Point(409, 205);
            this.lastNameField.Name = "lastNameField";
            this.lastNameField.Size = new System.Drawing.Size(193, 22);
            this.lastNameField.TabIndex = 1;
            // 
            // moderatorRadioButton
            // 
            this.moderatorRadioButton.AutoSize = true;
            this.moderatorRadioButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.moderatorRadioButton.Location = new System.Drawing.Point(409, 269);
            this.moderatorRadioButton.Name = "moderatorRadioButton";
            this.moderatorRadioButton.Size = new System.Drawing.Size(108, 25);
            this.moderatorRadioButton.TabIndex = 2;
            this.moderatorRadioButton.TabStop = true;
            this.moderatorRadioButton.Text = "Moderatör";
            this.moderatorRadioButton.UseVisualStyleBackColor = true;
            // 
            // serviceRadioButton
            // 
            this.serviceRadioButton.AutoSize = true;
            this.serviceRadioButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.serviceRadioButton.Location = new System.Drawing.Point(409, 305);
            this.serviceRadioButton.Name = "serviceRadioButton";
            this.serviceRadioButton.Size = new System.Drawing.Size(121, 25);
            this.serviceRadioButton.TabIndex = 3;
            this.serviceRadioButton.TabStop = true;
            this.serviceRadioButton.Text = "Teknik Servis";
            this.serviceRadioButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addButton.Location = new System.Drawing.Point(409, 410);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(108, 30);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Ekle";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updateButton.Location = new System.Drawing.Point(542, 410);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(108, 30);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "Güncelle";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteButton.Location = new System.Drawing.Point(678, 410);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(108, 30);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Kaldır";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // districtListBox
            // 
            this.districtListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.districtListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.districtListBox.FormattingEnabled = true;
            this.districtListBox.ItemHeight = 21;
            this.districtListBox.Location = new System.Drawing.Point(626, 160);
            this.districtListBox.Name = "districtListBox";
            this.districtListBox.Size = new System.Drawing.Size(159, 231);
            this.districtListBox.TabIndex = 9;
            this.districtListBox.SelectedIndexChanged += new System.EventHandler(this.districtListBox_SelectedIndexChanged);
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
            this.bicycleDataGridView.Location = new System.Drawing.Point(38, 70);
            this.bicycleDataGridView.Name = "bicycleDataGridView";
            this.bicycleDataGridView.ReadOnly = true;
            this.bicycleDataGridView.Size = new System.Drawing.Size(343, 460);
            this.bicycleDataGridView.TabIndex = 8;
            // 
            // ModeratorManagementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.districtListBox);
            this.Controls.Add(this.bicycleDataGridView);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.serviceRadioButton);
            this.Controls.Add(this.moderatorRadioButton);
            this.Controls.Add(this.lastNameField);
            this.Controls.Add(this.firstNameField);
            this.Name = "ModeratorManagementControl";
            this.Size = new System.Drawing.Size(824, 600);
            this.Load += new System.EventHandler(this.ModeratorManagementControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bicycleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameField;
        private System.Windows.Forms.TextBox lastNameField;
        private System.Windows.Forms.RadioButton moderatorRadioButton;
        private System.Windows.Forms.RadioButton serviceRadioButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ListBox districtListBox;
        private System.Windows.Forms.DataGridView bicycleDataGridView;
    }
}

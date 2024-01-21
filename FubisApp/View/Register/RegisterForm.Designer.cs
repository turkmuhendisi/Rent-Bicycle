namespace Fubis
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.nationalIdField = new System.Windows.Forms.TextBox();
            this.emailField = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.closePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nationalIdField
            // 
            this.nationalIdField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nationalIdField.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nationalIdField.Location = new System.Drawing.Point(300, 283);
            this.nationalIdField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nationalIdField.MaxLength = 11;
            this.nationalIdField.Name = "nationalIdField";
            this.nationalIdField.Size = new System.Drawing.Size(426, 22);
            this.nationalIdField.TabIndex = 6;
            // 
            // emailField
            // 
            this.emailField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailField.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.emailField.Location = new System.Drawing.Point(300, 403);
            this.emailField.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.emailField.MaxLength = 150;
            this.emailField.Name = "emailField";
            this.emailField.Size = new System.Drawing.Size(426, 22);
            this.emailField.TabIndex = 7;
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.Transparent;
            this.registerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.FlatAppearance.BorderSize = 0;
            this.registerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.registerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Location = new System.Drawing.Point(408, 487);
            this.registerButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(209, 39);
            this.registerButton.TabIndex = 8;
            this.registerButton.UseVisualStyleBackColor = false;
            // 
            // closePictureBox
            // 
            this.closePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePictureBox.Image = global::FubisApp.Properties.Resources.close;
            this.closePictureBox.Location = new System.Drawing.Point(974, 12);
            this.closePictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.closePictureBox.Name = "closePictureBox";
            this.closePictureBox.Size = new System.Drawing.Size(37, 37);
            this.closePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closePictureBox.TabIndex = 9;
            this.closePictureBox.TabStop = false;
            this.closePictureBox.Click += new System.EventHandler(this.closePictureBox_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.closePictureBox);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.emailField);
            this.Controls.Add(this.nationalIdField);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nationalIdField;
        private System.Windows.Forms.TextBox emailField;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.PictureBox closePictureBox;
    }
}